using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorClicks
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = contador.ToString();
            if (contador == 10) { MessageBox.Show("Felicitaciones llegaste a  10!"); }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
                lblContador.Text = contador.ToString();
            }
            else
            {
                MessageBox.Show("No se puede bajar de 0!");
            }

           
        }
    }
}
