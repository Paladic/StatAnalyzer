using Accord.Statistics.Testing;
using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace StatAnalyzer
{
    public static class StatisticalTestsCalculator
    {
        public static double CalPairedTTest(List<List<double>> samples)
        {
            double[] a = samples[0].ToArray();
            double[] b = samples[1].ToArray();

            var test = new PairedTTest(a, b);
            return test.PValue;
        }
        public static double CalWilcoxonTest(List<List<double>> samples)
        {
            double[] a = samples[0].ToArray();
            double[] b = samples[1].ToArray();

            var test = new TwoSampleWilcoxonSignedRankTest(a, b);
            return test.PValue;
        }

        public static double CalStudentTTest(List<List<double>> samples)
        {
            double[] a = samples[0].ToArray();
            double[] b = samples[1].ToArray();

            var test = new TwoSampleTTest(a, b, assumeEqualVariances: true, alternate: TwoSampleHypothesis.ValuesAreDifferent);

            return test.PValue;
        }

        public static double CalWelchTTest(List<List<double>> samples)
        {
            double[] a = samples[0].ToArray();
            double[] b = samples[1].ToArray();

            var test = new TwoSampleTTest(a, b, assumeEqualVariances: false, alternate: TwoSampleHypothesis.ValuesAreDifferent);

            return test.PValue;
        }

        public static double CalMannWhitneyTest(List<List<double>> samples)
        {
            double[] a = samples[0].ToArray();
            double[] b = samples[1].ToArray();

            var test = new MannWhitneyWilcoxonTest(a, b, TwoSampleHypothesis.ValuesAreDifferent);

            return test.PValue;
        }

        public static double CalOneWayAnova(List<List<double>> samples)
        {
            double[][] groups = samples.Select(s => s.ToArray()).ToArray();

            var anova = new OneWayAnova(groups);
            return anova.FTest.PValue;
        }

        public static double CalKruskalWallisTest(List<List<double>> samples)
        {
            int k = samples.Count;
            int N = samples.Sum(s => s.Count);

            // 1. Объединяем все значения в одну коллекцию с пометкой, к какой группе они относятся
            var allValues = new List<(double value, int groupIndex)>();
            for (int i = 0; i < samples.Count; i++)
            {
                foreach (var val in samples[i])
                    allValues.Add((val, i));
            }

            // 2. Присваиваем ранги
            var ranked = allValues
                .OrderBy(x => x.value)
                .Select((x, index) => (x.value, x.groupIndex, rank: index + 1))
                .ToList();

            // 3. Суммируем ранги по группам
            double[] rankSums = new double[k];
            int[] groupSizes = new int[k];

            foreach (var item in ranked)
            {
                rankSums[item.groupIndex] += item.rank;
                groupSizes[item.groupIndex]++;
            }

            // 4. Вычисляем H-статистику
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += (rankSums[i] * rankSums[i]) / groupSizes[i];
            }

            double H = (12.0 / (N * (N + 1))) * sum - 3 * (N + 1);

            // 5. p-value через распределение хи-квадрат
            double pValue = 1.0 - ChiSquared.CDF(k - 1, H);

            return pValue;
        }

        public static double CalFriedmanTest(List<List<double>> samples)
        {
            int k = samples.Count; 
            int n = samples[0].Count;

            double[,] data = new double[n, k];
            for (int j = 0; j < k; j++)
                for (int i = 0; i < n; i++)
                    data[i, j] = samples[j][i];

            double[,] ranks = new double[n, k];
            for (int i = 0; i < n; i++)
            {
                var row = new List<(double value, int index)>();
                for (int j = 0; j < k; j++)
                    row.Add((data[i, j], j));

                var ranked = row.OrderBy(x => x.value).ToList();
                double[] rowRanks = new double[k];
                int rank = 1;
                for (int j = 0; j < k;)
                {
                    int start = j;
                    double val = ranked[j].value;
                    while (j < k && ranked[j].value == val)
                        j++;
                    double avgRank = (rank + rank + (j - start) - 1) / 2.0;
                    for (int l = start; l < j; l++)
                        rowRanks[ranked[l].index] = avgRank;
                    rank += j - start;
                }

                for (int j = 0; j < k; j++)
                    ranks[i, j] = rowRanks[j];
            }

            double[] columnRankSums = new double[k];
            for (int j = 0; j < k; j++)
                for (int i = 0; i < n; i++)
                    columnRankSums[j] += ranks[i, j];

            double sumSquares = columnRankSums.Sum(r => r * r);
            double Q = (12.0 / (n * k * (k + 1))) * sumSquares - 3 * n * (k + 1);

            int df = k - 1;

            double pValue = 1.0 - ChiSquared.CDF(df, Q);

            return pValue;
        }
    }
}
