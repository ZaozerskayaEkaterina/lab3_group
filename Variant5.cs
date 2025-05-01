using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab3
{
    public partial class Variant5 : Form
    {
        private int[] years;
        private double[] population;

        public Variant5()
        {
            InitializeComponent();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("YearColumn", "Год");
            dataGridView1.Columns.Add("PopulationColumn", "Население");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл с данными о населении";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ReadDataFromFile(openFileDialog.FileName);
                SetupDataGridView();
                // Заполнение DataGridView
                dataGridView1.Rows.Clear();
                for (int i = 0; i < years.Length; i++)
                {
                    dataGridView1.Rows.Add(years[i], population[i]);
                }

                // Построение графика
                BuildPopulationChart();

                // Вычисление максимального процента прироста и убыли
                CalculateMaxGrowthAndDecline();
            }
        }

        private void ReadDataFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath)
                            .Where(line => !string.IsNullOrWhiteSpace(line)) // пропускаем пустые строки
                            .ToArray();

            years = new int[lines.Length];
            population = new double[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                var data = lines[i].Trim()
                                   .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (data.Length != 2)
                {
                    MessageBox.Show($"Неверный формат строки:\n{lines[i]}", "Ошибка чтения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                try
                {
                    years[i] = int.Parse(data[0]);
                    population[i] = double.Parse(data[1].Replace(',', '.'), CultureInfo.InvariantCulture);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Ошибка при разборе строки:\n{lines[i]}\n\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuildPopulationChart()
        {
            chart1.Series.Clear();

            var series = new Series
            {
                Name = "Population",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Line
            };

            for (int i = 0; i < years.Length; i++)
            {
                series.Points.AddXY(years[i], population[i]);
            }

            chart1.Series.Add(series);

            double minY = population.Min();
            double maxY = population.Max();
            double range = maxY - minY;
            double padding = range * 0.05;

            var axisY = chart1.ChartAreas[0].AxisY;
            axisY.Minimum = Math.Floor(minY - padding);
            axisY.Maximum = Math.Ceiling(maxY + padding);
            axisY.IsStartedFromZero = false;

            // Автоматический шаг с округлением до целого
            axisY.Interval = Math.Ceiling((axisY.Maximum - axisY.Minimum) / 10); // около 10 делений

        }

        private void CalculateMaxGrowthAndDecline()
        {
            double maxGrowth = 0;
            double maxDecline = 0;
            int growthYear = 0;
            int declineYear = 0;

            for (int i = 1; i < years.Length; i++)
            {
                double growth = (population[i] - population[i - 1]) / population[i - 1] * 100;
                if (growth > maxGrowth)
                {
                    maxGrowth = growth;
                    growthYear = years[i];
                }

                double decline = (population[i - 1] - population[i]) / population[i - 1] * 100;
                if (decline > maxDecline)
                {
                    maxDecline = decline;
                    declineYear = years[i];
                }
            }

            label1.Text = $"Максимальный прирост населения: на {maxGrowth:F2}% в {growthYear}";
            label2.Text = $"Максимальное сокращение населения: на {maxDecline:F2}% в {declineYear}";
        }

        private void ForecastPopulation(int yearsToForecast)
        {
            // Получаем число значений n для скользящей средней от пользователя
            int smoothing = (int)numericUpDownN.Value;

            if (smoothing <= 0 || smoothing > population.Length)
            {
                MessageBox.Show("Некорректное значение для скользящей средней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] smoothedPopulation = new double[population.Length];

            List<double> allValues = population.ToList();
            double[] forecast = new double[yearsToForecast];

            for (int i = 0; i < yearsToForecast; i++)
            {
                double avg = allValues.Skip(allValues.Count - smoothing).Take(smoothing).Average();
                forecast[i] = avg;
                allValues.Add(avg);
            }

            if (chart1.Series.IndexOf("Прогноз") >= 0)
            {
                chart1.Series.Remove(chart1.Series["Прогноз"]);
            }

            // Строим график прогнозов
            var forecastSeries = new Series
            {
                Name = "Прогноз",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Line,
                BorderDashStyle = ChartDashStyle.Dash,
                Color = System.Drawing.Color.Red
            };

            forecastSeries.Points.AddXY(years.Last(), population.Last());

            for (int i = 0; i < yearsToForecast; i++)
            {
                forecastSeries.Points.AddXY(years.Last() + i + 1, forecast[i]);
            }

            chart1.Series.Add(forecastSeries);
        }

        private void buttonForecast_Click(object sender, EventArgs e)
        {
            // Получаем количество лет для прогнозирования
            int yearsToForecast = (int)numericUpDownForecastYears.Value;

            if (yearsToForecast > 0)
            {
                // Прогнозируем население
                ForecastPopulation(yearsToForecast);
            }
            else
            {
                MessageBox.Show("Введите количество лет для прогнозирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
