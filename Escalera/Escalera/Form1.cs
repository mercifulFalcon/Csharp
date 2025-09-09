using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escalera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            if (int.TryParse(txtMin.Text, out int min) &&
                int.TryParse(txtMax.Text, out int max))
            {
                if (min < max)
                {
                    for (int i = min; i <= max; i++)
                    {
                        lstResultados.Items.Add(i.ToString("000"));
                    }
                }
                else if (min > max)
                {
                    for (int i = min; i >= max; i--)
                    {
                        lstResultados.Items.Add(i.ToString("000"));
                    }
                }
                else
                {
                    MessageBox.Show("Los números son iguales");
                }
            }
            else
            {
                MessageBox.Show("Algún número es invalido");
            }
        }
    }
}
