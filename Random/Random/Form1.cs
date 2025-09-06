using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    public partial class Form1 : Form
    {
        private System.Random rnd = new System.Random();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int elegido = (rnd.Next(2) == 0) ? num1 : num2;

            label1.Text = $" {elegido}";
        }
    }
}
