using ScottPlot;
using ScottPlot.NamedColors;
using ScottPlot.Statistics;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;


namespace StatAnalyzer
{
    public partial class plotForm : Form
    {
        private readonly FormsPlot formsPlot = new FormsPlot() { Dock = DockStyle.Fill };

        public plotForm()
        {
            // Создаём панель и добавляем в неё график
            var panel = new Panel() { Dock = DockStyle.Fill };
            panel.Controls.Add(formsPlot);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
            this.Controls.Add(panel);

            if (Samples.RecommendedTest == SamplesAnalyzer.StatisticalTest.PairedTTest
                || Samples.RecommendedTest == SamplesAnalyzer.StatisticalTest.Wilcoxon)
            {
                PlotScatterWithTrend(Samples.AllSamples[0].ToArray(), Samples.AllSamples[1].ToArray());
            }
            else
            {
                PlotBoxPlot(Samples.AllSamples);
            }
        }

        private void PlotScatterWithTrend(double[] xs, double[] ys)
        {
            formsPlot.Plot.Clear();
            formsPlot.Plot.Add.Palette = new ScottPlot.Palettes.Dark();

            var scatter = formsPlot.Plot.Add.Scatter(xs, ys);
            scatter.LineWidth = 0;
            scatter.MarkerSize = 10;
            scatter.MarkerShape = MarkerShape.FilledCircle;
            scatter.Label = "Данные";

            var reg = new ScottPlot.Statistics.LinearRegression(xs, ys);
            double minX = xs.Min();
            double maxX = xs.Max();

            Coordinates pt1 = new(minX, reg.GetValue(minX));
            Coordinates pt2 = new(maxX, reg.GetValue(maxX));

            var line = formsPlot.Plot.Add.Line(pt1, pt2);
            line.MarkerSize = 0;
            line.LineWidth = 2;
            line.LinePattern = LinePattern.Dashed;
            line.Label = "Линия регрессии";

            double r = PearsonCorrelation(xs, ys);
            formsPlot.Plot.Add.Text($"r = {r:F3}", xs.Min(), ys.Max() * 0.95);

            formsPlot.Plot.Title("Точечный график");
            formsPlot.Plot.XLabel("X");
            formsPlot.Plot.YLabel("Y");

            formsPlot.Refresh();
        }

        private void PlotBoxPlot(List<List<double>> samples)
        {
            formsPlot.Plot.Clear();
            formsPlot.Plot.Add.Palette = new ScottPlot.Palettes.Dark();

            double spacing = 1;
            double pos = 1;

            for (int i = 0; i < samples.Count; i++)
            {
                var sample = samples[i];
                var sorted = sample.OrderBy(x => x).ToArray();
                int n = sorted.Length;

                double q1 = sorted.LowerQuartile();
                double q2 = sorted.Median();
                double q3 = sorted.UpperQuartile();

                double iqr = q3 - q1;
                double whiskerMin = sorted.Where(v => v >= q1 - 1.5 * iqr).First();
                double whiskerMax = sorted.Where(v => v <= q3 + 1.5 * iqr).Last();

                var box = new ScottPlot.Box
                {
                    Position = pos,
                    BoxMin = q1,
                    BoxMax = q3,
                    BoxMiddle = q2,
                    WhiskerMin = whiskerMin,
                    WhiskerMax = whiskerMax,
                };

                var bp = formsPlot.Plot.Add.Box(box);
                bp.LegendText = $"Выборка {i + 1}";

                pos += spacing;
            }

            formsPlot.Plot.XLabel("Номер выборки");
            formsPlot.Plot.YLabel("Значения");
            formsPlot.Plot.Title("BoxPlot (ящик с усами)");
            formsPlot.Plot.Axes.AutoScale();

            formsPlot.Refresh();
        }

        private static double PearsonCorrelation(double[] x, double[] y)
        {
            int n = x.Length;
            double meanX = x.Average();
            double meanY = y.Average();

            double sumNum = 0, sumDenX = 0, sumDenY = 0;

            for (int i = 0; i < n; i++)
            {
                double dx = x[i] - meanX;
                double dy = y[i] - meanY;

                sumNum += dx * dy;
                sumDenX += dx * dx;
                sumDenY += dy * dy;
            }

            return sumNum / Math.Sqrt(sumDenX * sumDenY);
        }
    }
}
