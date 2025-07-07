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
        public static void AnalyzeSamples()
        {
            List<List<double>> allSamples = Samples.AllSamples;

            Samples.IsSameSize = allSamples.All(s => s.Count == allSamples[0].Count);
            if(Samples.IsSameSize) Samples.IsGaussian = AnalyzeSamplesDistribution();

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

        public static bool IsNormallyDistributed(List<double> sample)
        {
            var test = new ShapiroWilkTest(sample.ToArray());
            double pValue = test.PValue;
            return pValue > 0.05;
        }
    }
}
