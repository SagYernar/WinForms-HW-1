using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Number number = new Number();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загадайте число от 1 до 2000");
            labelNumber.Text = (number.MyNumber).ToString();
            buttonBigger.Visible = true;
            buttonLower.Visible = true;
            buttonEndGame.Visible = true;
            labelNumber.Visible = true;
        }

        private void ButtonBigger_Click(object sender, EventArgs e)
        {
            number.Bigger();
            labelNumber.Text = (number.MyNumber).ToString();
        }

        private void ButtonLower_Click(object sender, EventArgs e)
        {
            number.Lower();
            labelNumber.Text = (number.MyNumber).ToString();
        }

        private void ButtonEndGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Ваше число было отгадано за {0} ходов", number.Count));
            number.MyNumber = 1000;
            number.Highest = 2001;
            number.Lowest = 0;
            number.Count = 0;
            buttonBigger.Visible = false;
            buttonLower.Visible = false;
            buttonEndGame.Visible = false;
            labelNumber.Visible = false;
        }
    }
}
