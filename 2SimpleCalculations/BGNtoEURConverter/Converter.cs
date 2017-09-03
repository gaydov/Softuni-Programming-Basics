using System;
using System.Windows.Forms;

namespace BGNtoEURConverter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            this.InitializeComponent();
        }

        private void ConvertCurrency()
        {
            decimal amountBGN = this.numericUpDownAmount.Value;
            decimal amountEUR = amountBGN / 1.95583m;
            this.labelResult.Text =
              amountBGN + " BGN = " +
              Math.Round(amountEUR, 2) + "EUR";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ConvertCurrency();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            this.ConvertCurrency();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            this.ConvertCurrency();
        }
    }
}
