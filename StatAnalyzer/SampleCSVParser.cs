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
        public static bool isSamplesValid(string[] lines)
        {
            if (lines.Length < 2)
            {
                MessageBox.Show($"Количество выборок меньше, чем допустимое количество. Текущее — {lines.Length}, минимальное допустимое — 2.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (lines.Length > 10)
            {
                MessageBox.Show($"Количество выборок превышает допустимое количество. Текущее — {lines.Length}, максимальное допустимое — 10.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static List<List<double>> TextToSamples(string[] lines)
        {
            List<List<double>> samples = new List<List<double>>();

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];

                var sample = line
                    .Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => double.Parse(s.Trim(), CultureInfo.InvariantCulture))
                    .ToList();

                if (sample.Count > 100)
                {
                    throw new InvalidOperationException($"Выборка {i + 1} превышает допустимое количетсво элементов. Текущее — {sample.Count}, максимальное допустимое — 100.");
                }
                else if (sample.Count < 4)
                {
                    throw new InvalidOperationException($"Выборка {i + 1} содержит меньше элементов, чем допустимо. Текущее — {sample.Count}, минимальное допустимое — 4.");
                }


                samples.Add(sample);
            }

            return samples;
        }
    }
}
