using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinarNumero
{
    public partial class Form1 : Form
    {

        private int numeroSecreto;
        private int intentos;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            IniciarJuego();

            
            this.AcceptButton = btnComprobar;
        }

        private void IniciarJuego()
        {
            numeroSecreto = random.Next(1, 21); 
            intentos = 0;
            lblResultado.Text = " ";
           txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int intento))
            {
                intentos++;

                switch (intento.CompareTo(numeroSecreto))
                {
                    case -1:
                        lblResultado.Text = "El número es mayor.";
                        break;
                    case 1:
                        lblResultado.Text = "El número es menor.";
                        break;
                    case 0:
                        MessageBox.Show($"¡Adivinaste! y lo hiciste en {intentos} intentos");
                        IniciarJuego();
                        return;
                }

                
                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
                
            }
                txtNumero.Clear();
                txtNumero.Focus();
        }
    }
}