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
        }

        private void IniciarJuego()
        {
            numeroSecreto = random.Next(1,21);
            
            txtNumero.Clear();  
            txtNumero.Focus();  
        }

        private void btnComproar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int intento) && (intento <= 20))
            {
                intentos++;

                int comparacion = intento.CompareTo(numeroSecreto);

                switch (comparacion)
                {
                    case -1:
                        lblResultado.Text = "El número es más grande";
                        break;

                    case 1:
                        lblResultado.Text = "El número es mas chico";
                        break;

                    case 0:
                        MessageBox.Show($"Ganaste, y lo hiciste en {intentos} intentos");
                        IniciarJuego();
                        return;
                }

                txtNumero.Clear();
                txtNumero.Focus();  
            }
            else
            {
                MessageBox.Show("Ingresá un número válido");
            }
            txtNumero.Clear();
            txtNumero.Focus();
        }
        }
    }

