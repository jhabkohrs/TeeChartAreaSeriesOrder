using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace TeeChartAreaGraphSeriesOrder
{
    public partial class Form1 : Form
    {
        private TChart _chart;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _chart = new TChart();
            this.pnlChart.Controls.Add(_chart);
            _chart.Aspect.View3D = true;
            _chart.Dock = DockStyle.Fill;
            cboAreaType.SelectedIndex = 0;
        }

        private void cboAreaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chart.Series.Clear();
            var series1 = cboAreaType.SelectedIndex == 0 ? new Area() : new CustomArea();
            series1.Add(1, 2);
            series1.Add(2, 3);
            var series2 = cboAreaType.SelectedIndex == 0 ? new Area() : new CustomArea();
            series2.Add(1, 1);
            series2.Add(2, 2);
            _chart.Series.Add(series1);
            _chart.Series.Add(series2);
        }

        private class CustomArea : Area
        {
            protected override bool DrawSeriesAscending()
            {
                return !Chart.Axes.Depth.Inverted;
            }
        }
    }
}
