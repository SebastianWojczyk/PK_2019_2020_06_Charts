using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Charts
{
    public partial class UserControlPolynomial : UserControl, IFunction
    {
        public UserControlPolynomial()
        {
            InitializeComponent();
            groupBox.Text = FunctionName;
        }

        public string FunctionName
        {
            get
            {
                return string.Format("f(x) = {0}*x + {1}", numericUpDownA.Value, numericUpDownB.Value);
            }
        }

        public event emptyFunction FunctionChanged;

        public double Value(double x)
        {
            return (double)(numericUpDownA.Value) * x + (double)numericUpDownB.Value;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            groupBox.Text = FunctionName;
            if (FunctionChanged != null)
            {
                FunctionChanged();
            }
        }
    }
}
