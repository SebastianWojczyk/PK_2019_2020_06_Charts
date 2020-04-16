using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _06_Charts
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();

            Series s = new Series();
            s.Name = "My function";

            s.ChartType = SeriesChartType.Line;

            for (double x = -10; x <= 10; x += 0.1)
            {
                s.Points.AddXY(x, x * x);
            }

            chart.Series.Add(s);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserControlPolynomial newPolynomial = new UserControlPolynomial();
            flowLayoutPanelControls.Controls.Add(newPolynomial);
        }

        private void userControlPolynomial1_FunctionChanged()
        {

        }
    }
}
