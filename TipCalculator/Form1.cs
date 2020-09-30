using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Double.TryParse(billTxtBox.Text, out double billAmt);
            Double.TryParse(TipPrcntTxtBox.Text, out double tipPrcnt);
            double tipAmt = billAmt * (tipPrcnt / 100);
            TipTxtBox.Text = tipAmt.ToString();
            double totalAmt = billAmt + tipAmt;
            TotalAmtTxtBox.Text = totalAmt.ToString();
        }

        private void billTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(billTxtBox.Text, out _))
            {
                calculateButton.Enabled = true;
            }
            else
            {
                calculateButton.Enabled = false;
            }
        }

        private void TipPrcntTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TipPrcntTxtBox.Text, out _))
            {
                calculateButton.Enabled = true;
            }
            else
            {
                calculateButton.Enabled = false;
            }
        }
    }
}
