using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using DevExpress.XtraCharts;

namespace GUI
{
    public partial class US_ThongKe_Ngay : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_TblHoaDon hd = new BLL_TblHoaDon();
        BLL_TblBan ban = new BLL_TblBan();
        public US_ThongKe_Ngay()
        {
            InitializeComponent();
        }

        private void US_ThongKe_Ngay_Load(object sender, EventArgs e)
        {
            loadControlDoanhThu();
            loadControlHoaDon();
            loadPieChart_HieuXuat();
        }

        public void loadControlDoanhThu()
        {
            String temp = hd.getTongTienHD_HomNay();
            if (temp == null || temp == String.Empty)
                temp = "0 VNĐ";
            lbl_TienBanHang.Text = temp;
        }

        public void loadControlHoaDon()
        {
            int soHDChuaTT = hd.getDSHoaDonChuaThanhToan_HomNay();
            int soHDDaTT = hd.getDSHoaDonDaThanhToan_HomNay();
            lbl_DaThanhToan.Text = soHDDaTT.ToString();
            lbl_DangPV.Text = soHDChuaTT.ToString();
        }

        public void loadPieChart_HieuXuat()
        {
            // Create a new chart.
            ChartControl DoughnutChart = new ChartControl();

            // Create a doughnut series.
            Series series1 = new Series("Series 1", ViewType.Doughnut);

            int banDanSD = ban.getSoBanDangSuDung();
            int banTrong = ban.getSoBanDangTrong();
            int tongSoBan = ban.getTongSoBan();

            float hieuSuat = banDanSD * 100 / tongSoBan;

            float conLai = 100 - hieuSuat;


            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Hiệu suất", hieuSuat));
            series1.Points.Add(new SeriesPoint("Còn trống", conLai));


            // Add the series to the chart.
            DoughnutChart.Series.Add(series1);

            // Specify the text pattern of series labels.
            series1.Label.TextPattern = "{A}: {VP:P0}";

            // Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument;

            // Specify the behavior of series labels.
            ((DoughnutSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMinIndent = 5;

            // Adjust the view-type-specific options of the series.
            ((DoughnutSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((DoughnutSeriesView)series1.View).ExplodedDistancePercentage = 30;

            // Access the diagram's options.
            ((SimpleDiagram)DoughnutChart.Diagram).Dimension = 2;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "2D Doughnut Chart";
            DoughnutChart.Titles.Add(chartTitle1);
            DoughnutChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            DoughnutChart.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(DoughnutChart);
        }

    }
}
