using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatAnalyzer
{
    public static class InterfaceHelper
    {
        public static Dictionary<string, string> labels = new Dictionary<string, string>
        {
            ["dependent"] = "Выборки зависимые.",
            ["independent"] = "Выборки независимые.",
            ["sameSize"] = $"Размер выборок одинаковый. Каждая выборка содержит {Samples.AllSamples[0].Count} элементов.",
            ["diffSize"] = "Выборки разного размера.",
            ["gausDistr"] = "Все выборки имеют нормальное распределение согласно тесту Шапиро–Уилка.",
            ["noDistr"] = "Нормальность распределения не подтверждена для всех выборок согласно тесту Шапиро–Уилка."
        };

        public static string BuildAnalysisSummary()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Samples.IsDependent ? labels["dependent"] : labels["independent"]);
            sb.AppendLine(Samples.IsSameSize ? labels["sameSize"] : labels["diffSize"]);

            if (Samples.IsSameSize && Samples.IsGaussian)
                sb.AppendLine(labels["gausDistr"]);
            else if (Samples.IsSameSize && !Samples.IsGaussian)
                sb.AppendLine(labels["noDistr"]);
            else sb.AppendLine("Проверка на нормальность распределения не проводилась из-за различий в размерах выборок");


            return sb.ToString();
        }

        public static void SamplesToGrid(DataGridView grid, List<List<double>> samples)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            int maxCols = samples.Max(s => s.Count);

            for (int i = 0; i < maxCols; i++)
            {
                grid.Columns.Add($"", $"");
            }

            for (int row = 0; row < samples.Count; row++)
            {
                var sample = samples[row];
                var rowValues = new string[maxCols];
                for (int col = 0; col < sample.Count; col++)
                    rowValues[col] = sample[col].ToString();

                grid.Rows.Add(rowValues);
                grid.Rows[row].HeaderCell.Value = $"Выборка {row + 1}";
            }
        }
    }
}
