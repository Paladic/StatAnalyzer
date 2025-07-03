using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatAnalyzer
{
    public static class InterfaceHelper
    {
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
