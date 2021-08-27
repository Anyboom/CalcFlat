using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalcFlat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalcAction_Click(object sender, EventArgs e)
        {
            ulong bank = Convert.ToUInt64(BankTextBox.Text);
            byte percent = Convert.ToByte(FlatTextBox.Text);

            string[] mainBase = File.ReadAllLines(BasePathTextBox.Text);

            foreach (string line in mainBase)
            {
                bool symbol = line.Split(',')[0] == "+";
                float coef = Convert.ToSingle(line.Split(',')[1].Replace(".", ","));
                ulong bid = Convert.ToUInt64(Math.Round(bank * (percent / 100.0)));

                if (symbol)
                {
                    bank += Convert.ToUInt64(Math.Round(bid * coef)) - bid;
                }
                else
                {
                    bank -= bid;
                }
            }

            ProfitBaseResultLabel.Text = bank.ToString();
        }

        private void BasePathTextBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый документ|*.txt";
            openFile.CheckFileExists = true;

            DialogResult openResult = openFile.ShowDialog();

            if(openResult == DialogResult.OK)
            {
                BasePathTextBox.Text = openFile.FileName;
            }
        }
    }
}
