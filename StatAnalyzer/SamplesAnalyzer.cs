using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Testing;

namespace StatAnalyzer
{
    public class SamplesAnalyzer
    {
        public enum SamplesSize
        {
            SmallSamples,           // < 30
            LargeSamples,           // >= 30
            DifferentSamples,       // сильно различаются по длине
            None
        }

        public enum StatisticalTest
        {
            // для двух выборок
            None,
            PairedTTest,             // Парный t-тест
            Wilcoxon,                // Тест Вилкоксона
            StudentTTest,            // Классический t-тест Стьюдента
            WelchTTest,              // t-тест Уэлча
            MannWhitney,             // U-критерий Манна–Уитни
            // для трех и более
            Anova,                  // Однофакторный дисперсионный анализ (One-way ANOVA)
            RepeatedMeasuresAnova,  // ANOVA для повторных измерений
            KruskalWallis,          // Критерий Краскела–Уоллиса
            Friedman                // Критерий Фридмана
        }

        public static void AnalyzeSamples()
        {
            List<List<double>> allSamples = Samples.AllSamples;

            Samples.IsSameSize = allSamples.All(s => s.Count == allSamples[0].Count);
            if(Samples.IsSameSize) Samples.IsGaussian = AnalyzeSamplesDistribution();

            Samples.SampleSize = AnalyzeSize();
            Samples.RecommendedTest = GetRecommendedTest();

            double levpVal = -1;
            Samples.IsEqualVariance = LeveneTestAccord(out levpVal);
            Samples.LevenePVal = levpVal;
        }
        public static bool AnalyzeSamplesDistribution()
        {
            List<List<double>> allSamples = Samples.AllSamples;
            bool allNormal = true;
            int expectedSize = allSamples[0].Count;

            foreach (var sample in allSamples)
            {
                bool normal = IsNormallyDistributed(sample);

                if (!normal)
                    allNormal = false;
            }
            return allNormal;
        }
        public static SamplesSize AnalyzeSize()
        {
            int minSize = Samples.AllSamples.Min(s => s.Count);
            int maxSize = Samples.AllSamples.Max(s => s.Count);

            if (maxSize < 30 && minSize < 30) return SamplesSize.SmallSamples;
            else if (maxSize >= 30 && minSize >= 30) return SamplesSize.LargeSamples;
            else return SamplesSize.DifferentSamples;
        }

        public static bool IsNormallyDistributed(List<double> sample)
        {
            var test = new ShapiroWilkTest(sample.ToArray());
            double pValue = test.PValue;
            return pValue > 0.05;
        }

        public static bool LeveneTestAccord(out double pValue)
        {
            double[][] arrays = Samples.AllSamples.Select(s => s.ToArray()).ToArray();

            var test = new LeveneTest(arrays);
            pValue = test.PValue;

            return pValue > 0.05;
        }

        public static StatisticalTest GetRecommendedTest()
        {
            if (Samples.AllSamples.Count == 2) {
                return GetRecommendedTestForTwoSamples();
            }
            else if(Samples.AllSamples.Count > 2)
            {
                return GetRecommendedTestForMultipleSamples();
            }
            else return StatisticalTest.None;
        }

        public static StatisticalTest GetRecommendedTestForTwoSamples()
        {
            if (Samples.IsDependent)
            {
                if (Samples.IsGaussian)
                    return StatisticalTest.PairedTTest;
                else
                    return StatisticalTest.Wilcoxon;
            }
            else
            {
                if (Samples.IsGaussian)
                {
                    if (Samples.SampleSize == SamplesSize.SmallSamples)
                        return StatisticalTest.MannWhitney;
                    else if ((Samples.SampleSize == SamplesSize.DifferentSamples) || !Samples.IsEqualVariance)
                        return StatisticalTest.WelchTTest;
                    else
                        return StatisticalTest.StudentTTest;
                }
                else
                    return StatisticalTest.MannWhitney;
            }
        }

        public static StatisticalTest GetRecommendedTestForMultipleSamples()
        {
            if (Samples.IsDependent)
            {
                if (Samples.IsGaussian)
                    return StatisticalTest.RepeatedMeasuresAnova;
                else
                    return StatisticalTest.Friedman;
            }
            else
            {
                if (Samples.IsGaussian && Samples.IsEqualVariance)
                    return StatisticalTest.Anova;
                else
                    return StatisticalTest.KruskalWallis;
            }
        }

    }
}
