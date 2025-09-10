using System.Windows.Forms.DataVisualization.Charting;

namespace POSpresso.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadSalesChart();
        }
        private void LoadSalesChart()
        {
            var chart = new Chart();
            chart.Dock = DockStyle.Fill;

            // Create chart area
            var chartArea = new ChartArea("MainArea");
            chart.ChartAreas.Add(chartArea);

            // Create a series
            var salesSeries = new Series("Daily Sales")
            {
                ChartType = SeriesChartType.Column
            };

            // Example data (replace with your DB data)
            salesSeries.Points.AddXY("Monday", 120);
            salesSeries.Points.AddXY("Tuesday", 150);
            salesSeries.Points.AddXY("Wednesday", 90);
            salesSeries.Points.AddXY("Thursday", 200);
            salesSeries.Points.AddXY("Friday", 180);

            chart.Series.Add(salesSeries);

            this.Controls.Add(chart);
        }
    }
}
