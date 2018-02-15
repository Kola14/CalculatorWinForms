using System;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnPlusClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            int y = Convert.ToInt32(tbRawY.Text);
            int result = x + y;
            tbResult.Text = result.ToString();
        }

        private void BtnMinusClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            int y = Convert.ToInt32(tbRawY.Text);
            int result = x - y;
            tbResult.Text = result.ToString();
        }

        private void BtnMultClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            int y = Convert.ToInt32(tbRawY.Text);
            int result = x * y;
            tbResult.Text = result.ToString();
        }

        private void BtnPowClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            int y = Convert.ToInt32(tbRawY.Text);
            double result = Math.Pow(x, y);
            tbResult.Text = result.ToString();
        }


        private void BtnDivClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            int y = Convert.ToInt32(tbRawY.Text);
            double result = (double)x / y;
            tbResult.Text = result.ToString();
        }


        private void BtnModClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            int y = Convert.ToInt32(tbRawY.Text);
            int result = x % y;
            tbResult.Text = result.ToString();
        }

        private void BtnLogClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            int y = Convert.ToInt32(tbRawY.Text);
            double result = Math.Log(x,y);
            tbResult.Text = result.ToString();
        }

        private void BtnFacClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbRawX.Text);
            long result = Fact(x);
            tbResult.Text = result.ToString();
        }

        private long Fact(int value)
        {
            long result = 1;
            for (int i = 1; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
