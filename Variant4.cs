using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab3
{
    public partial class Variant_4 : Form
    {
        private DataTable dataTable; // Объявляем dataTable как поле класса

        public Variant_4()
        {
            dataTable = new DataTable();
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл с данными";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadData(openFileDialog.FileName);
                }
            }
        }

        // Заполнение таблицы
        private void LoadData(string filePath)
        {
            dataTable.Columns.Add("Год", typeof(int));
            dataTable.Columns.Add("ВВП (в млрд долларах)", typeof(decimal));
            dataTable.Columns.Add("ВНП (в млрд долларах)", typeof(decimal));

            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 3 &&
                        int.TryParse(parts[0], out int year) &&
                        decimal.TryParse(parts[1], out decimal gdp) &&
                        decimal.TryParse(parts[2], out decimal gnp))
                    {
                        dataTable.Rows.Add(year, gdp, gnp);
                    }
                }

                dataGridView1.DataSource = dataTable;

                // Проверка на наличие данных в dataTable
                if (dataTable.Rows.Count > 0)
                {
                    PlotChart(dataTable);
                }
                else
                {
                    MessageBox.Show("Нет данных для отображения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Отрисовка графика
        private void PlotChart(DataTable dataTable)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            // Создаем серию для ВВП (в млрд долларов)
            Series gdpSeries = new Series("ВВП (в млрд долларах)")
            {
                ChartType = SeriesChartType.Line,
                XValueMember = "Год",
                YValueMembers = "ВВП (в млрд долларах)",
                Color = Color.Blue // Цвет для фактических данных
            };

            // Создаем серию для ВНП (в млрд долларов)
            Series gnpSeries = new Series("ВНП (в млрд долларах)")
            {
                ChartType = SeriesChartType.Line,
                XValueMember = "Год",
                YValueMembers = "ВНП (в млрд долларах)",
                Color = Color.Green // Цвет для фактических данных
            };

            // Добавляем фактические серии на график
            chart1.Series.Add(gdpSeries);
            chart1.Series.Add(gnpSeries);

            // Устанавливаем источник данных для графика
            chart1.DataSource = dataTable;
            chart1.DataBind();
        }


        private void PlotForecastChart(DataTable dataTable)
        {
            // Очищаем предыдущие данные на новом графике
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("ForecastArea");
            chart2.ChartAreas.Add(chartArea);

            // Проверяем, есть ли фактические данные
            if (dataTable.Rows.Count > 0)
            {
                // Получаем последний год из данных
                DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
                int startYear = Convert.ToInt32(lastRow["Год"]); // Начинаем с последнего года из таблицы

                // Создаем серии для фактических и прогнозируемых ВВП и ВНП
                Series gdpSeries = new Series("ВВП (в млрд долларов)")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Red,
                };

                Series gnpSeries = new Series("ВНП (в млрд долларов)")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Orange,
                };

                // Добавляем фактические данные
                foreach (DataRow row in dataTable.Rows)
                {
                    int year = Convert.ToInt32(row["Год"]);
                    decimal gdpValue = Convert.ToDecimal(row["ВВП (в млрд долларах)"]);
                    decimal gnpValue = Convert.ToDecimal(row["ВНП (в млрд долларах)"]);

                    gdpSeries.Points.AddXY(year, gdpValue);
                    gnpSeries.Points.AddXY(year, gnpValue);
                }

                // Добавляем прогнозируемые значения для следующих трех лет
                for (int i = 1; i <= 3; i++)
                {
                    int forecastYear = startYear + i;
                    decimal gdpForecast = CalculateMovingAverage("ВВП (в млрд долларах)");
                    decimal gnpForecast = CalculateMovingAverage("ВНП (в млрд долларах)");

                    // Добавляем прогнозируемые точки
                    gdpSeries.Points.AddXY(forecastYear, gdpForecast);
                    gnpSeries.Points.AddXY(forecastYear, gnpForecast);
                }

                // Добавляем серии на график
                chart2.Series.Add(gdpSeries);
                chart2.Series.Add(gnpSeries);
            }
        }

        private void btnCalculateForecast_Click(object sender, EventArgs e)
        {
            // Получаем введенный год для прогноза
            int forecastYear = (int)numYear.Value;

            // Проверяем, что год больше последнего года в данных
            if (dataTable.Rows.Count == 0 || forecastYear <= Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1]["Год"]))
            {
                MessageBox.Show("Введите год, который больше последнего доступного года.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вычисляем прогнозируемые значения ВВП и ВНП с использованием скользящей средней
            decimal gdpForecast = CalculateMovingAverage("ВВП (в млрд долларах)");
            decimal gnpForecast = CalculateMovingAverage("ВНП (в млрд долларах)");

            // Добавляем прогнозируемые данные в таблицу
            DataRow newRow = dataTable.NewRow();
            newRow["Год"] = forecastYear;
            newRow["ВВП (в млрд долларах)"] = gdpForecast;
            newRow["ВНП (в млрд долларах)"] = gnpForecast;
            dataTable.Rows.Add(newRow);

            // После вычисления фактических данных
            PlotForecastChart(dataTable); // Для нового графика с прогнозами
        }

        private decimal CalculateMovingAverage(string columnName)
        {
            int period = 3; // Период для скользящей средней (например, 3 года)
            decimal total = 0;
            int count = 0;

            // Получаем последние N значений для вычисления скользящей средней
            for (int i = dataTable.Rows.Count - 1; i >= 0 && count < period; i--)
            {
                total += Convert.ToDecimal(dataTable.Rows[i][columnName]);
                count++;
            }

            // Возвращаем среднее значение
            return count > 0 ? Math.Round(total / count) : 0;
        }

        private void btnCalculatePercents_Click(object sender, EventArgs e)
        {

        }
    }
}
