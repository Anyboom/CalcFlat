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
using CalcFlat.Enums;

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
            string[] mainBase = default;

            if (File.Exists(BasePathTextBox.Text) == false)
                return;
            
            mainBase = File.ReadAllLines(BasePathTextBox.Text);

            ulong newBank = bank;

            foreach (string line in mainBase)
            {
                Symbols symbol = line.Split(',', 2)[0] switch{
                    "+" => Symbols.Plus,
                    "-" => Symbols.Minus,
                    "0" => Symbols.Zero
                };

                float coef = Convert.ToSingle(line.Split(',', 2)[1]);
                ulong bid = Convert.ToUInt64(Math.Round(newBank * (percent / 100.0)));

                newBank = symbol switch
                {
                    Symbols.Plus => newBank + Convert.ToUInt64(Math.Round(bid * coef)) - bid,
                    Symbols.Minus => newBank - bid,
                    Symbols.Zero => newBank
                };
            }

            string result = default;

            if (newBank > bank)
            {
                result = $"+ {Math.Truncate(((newBank - bank) / (bank * 1.0)) * 100)}%";
            }
            else
            {
                result = $"- {Math.Truncate(((bank - newBank) / (bank * 1.0)) * 100)}%";
            }

            ProfitBaseResultLabel.Text = newBank.ToString();
            ProfitPercentResultLabel.Text = result;
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
