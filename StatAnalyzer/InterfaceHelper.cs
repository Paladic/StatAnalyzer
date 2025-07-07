using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StatAnalyzer.SamplesAnalyzer;

namespace StatAnalyzer
{
    public static class InterfaceHelper
    {
        public static string BuildAnalysisSummary()
        {
            var labels = new Dictionary<string, string>
            {
                ["dependent"] = "Выборки зависимые.",
                ["independent"] = "Выборки независимые.",
                ["sameSize"] = $"Размер выборок одинаковый. Каждая выборка содержит {Samples.AllSamples[0].Count} элементов.",
                ["diffSize"] = "Выборки разного размера.",
                ["gausDistr"] = "Все выборки имеют нормальное распределение согласно тесту Шапиро–Уилка.",
                ["noDistr"] = "Нормальность распределения не подтверждена для всех выборок согласно тесту Шапиро–Уилка.",
                ["small"] = "Размер выборок — малый (менее 30 элементов в каждой выборке).",
                ["large"] = "Размер выборок — большой (не менее 30 элементов в каждой выборке).",
                ["diff"] = "Размеры выборок сильно различаются.",
                ["equalVar"] = $"Дисперсии выборок статистически равны согласно тесту Левена ({Samples.LevenePVal} > 0.05).",
                ["notEqualVar"] = $"Дисперсии выборок различаются согласно тесту Левена ({Samples.LevenePVal} ≤ 0.05).",
            };

            var sb = new StringBuilder();

            sb.AppendLine(Samples.IsDependent ? labels["dependent"] : labels["independent"]);
            sb.AppendLine(Samples.IsSameSize ? labels["sameSize"] : labels["diffSize"]);

            if (Samples.IsSameSize && Samples.IsGaussian)
                sb.AppendLine(labels["gausDistr"]);
            else if (Samples.IsSameSize && !Samples.IsGaussian)
                sb.AppendLine(labels["noDistr"]);
            else sb.AppendLine("Проверка на нормальность распределения не проводилась из-за различий в размерах выборок");

            sb.AppendLine();

            switch (Samples.SampleSize)
            {
                case SamplesSize.SmallSamples:
                    sb.AppendLine(labels["small"]);
                    break;
                case SamplesSize.LargeSamples:
                    sb.AppendLine(labels["large"]);
                    break;
                case SamplesSize.DifferentSamples:
                    sb.AppendLine(labels["diff"]);
                    break;
            }

            sb.AppendLine(Samples.IsEqualVariance ? labels["equalVar"] : labels["notEqualVar"]);

            sb.AppendLine("Рекомендованный тест:");
            sb.AppendLine(FormatTestName(Samples.RecommendedTest));

            return sb.ToString();
        }

        private static string FormatTestName(StatisticalTest test)
        {
            return test switch
            {
                StatisticalTest.PairedTTest => "Парный t-тест Стьюдента",
                StatisticalTest.Wilcoxon => "критерий знаковых рангов Уилкоксона",
                StatisticalTest.StudentTTest => "Классический t-тест Стьюдента",
                StatisticalTest.WelchTTest => "t-тест Уэлча",
                StatisticalTest.MannWhitney => "U-критерий Манна–Уитни",

                StatisticalTest.Anova => "Однофакторный дисперсионный анализ (One-way ANOVA)",
                StatisticalTest.RepeatedMeasuresAnova => "Дисперсионный анализ для повторных наблюдений (Repeated Measures ANOVA)",
                StatisticalTest.KruskalWallis => "Критерий Краскела–Уоллиса",
                StatisticalTest.Friedman => "Критерий Фридмана",
                _ => "Неизвестный тест"
            };
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
