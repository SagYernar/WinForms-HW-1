using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string FIO = "Сагадиев Ернар Габитович";
            string DateOfBirth = "Родился 10 июня 1994 года в городе Астане";
            string Languages = "Владеет следующими языками: русский, английский, японский";
            MessageBox.Show(FIO);
            MessageBox.Show(DateOfBirth);
            MessageBox.Show(Languages, ((FIO.Length+ Languages.Length + DateOfBirth.Length) / 3).ToString());
        }
    }
}
