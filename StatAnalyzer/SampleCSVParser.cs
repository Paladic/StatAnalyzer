using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace StatAnalyzer
{
    public static class SampleCSVParser
    {
        public static List<List<double>> TextToSamples(string[] lines)
        {
            List<List<double>> samples = new List<List<double>>();

            foreach (var line in lines)
            {
                var sample = line
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => double.Parse(s.Trim(), CultureInfo.InvariantCulture))
                    .ToList();

                samples.Add(sample);
            }
            return samples;
        }
    }
}
