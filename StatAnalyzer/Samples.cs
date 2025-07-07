using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StatAnalyzer.SamplesAnalyzer;

namespace StatAnalyzer
{
    public class Samples
    {
        public static List<List<double>> AllSamples { get; set; } = new List<List<double>>();
        public static bool IsDependent = false;
        public static bool IsGaussian = false;
        public static bool IsSameSize = false;
        public static bool IsEqualVariance = false;
        public static SamplesAnalyzer.SamplesSize SampleSize = SamplesAnalyzer.SamplesSize.None;
        public static SamplesAnalyzer.StatisticalTest RecommendedTest = SamplesAnalyzer.StatisticalTest.None;


        public static void ClearSamples()
        {
            AllSamples.Clear();
            IsDependent = false;
            IsGaussian = false;
            IsSameSize = false;
            IsEqualVariance = false;
            SampleSize = SamplesAnalyzer.SamplesSize.None;
            RecommendedTest = SamplesAnalyzer.StatisticalTest.None;
        }
    }
}
