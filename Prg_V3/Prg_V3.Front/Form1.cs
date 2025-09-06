using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg_V3.Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btComparar_Click(object sender, EventArgs e)
        {
            
            int dato1 = Convert.ToInt32(txtDato1.Text);
            int dato2 = Convert.ToInt32(txtDato2.Text);

            if (dato1 == dato2)
            {
                lblsalida.Text = "Los datos son iguales";
            }
            else if (dato1 > dato2)
            {

                lblsalida.Text = dato1 + " es mayor que " + dato2;

            }
            else 
            {
                lblsalida.Text = dato2 + " es mayor que " + dato1;

            }


         }

        private void btDividir_Click(object sender, EventArgs e)
        {
            //Comparar se la division del dato 1 es mayor al dato 2
            int dato1 = Convert.ToInt32(txtDato1.Text);
            int dato2 = Convert.ToInt32(txtDato2.Text);
            if (dato2 !=0 && (dato1 / dato2) > dato2)
            {

                lblsalida.Text = "Es mayor";

            }
            else if (dato2 == 0)
            {
                lblsalida.Text = "No se puede dividir por cero";
            }
            else
            {
                lblsalida.Text = "Es menor o igual";
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
          int dato1 = Convert.ToInt32(txtDato1.Text);
          int dato2 = Convert.ToInt32(txtDato2.Text);

          decimal Resultado = (dato1 + dato2) / 2;

            switch ((int)Resultado)
            {
                case 0:
                    lblsalida.Text = "Libre";
                    break;
                case 1:
                    lblsalida.Text = "Libre";
                    break;
                case 2:
                    lblsalida.Text = "Libre";
                    break;
                case 3:
                    lblsalida.Text = "Libre";
                    break;
                case 4:
                    lblsalida.Text = "Regular";
                    break;
                case 5:
                    lblsalida.Text = "Regular";
                    break;
                case 6:
                    lblsalida.Text = "Regular";
                    break;

                case 7:
                    lblsalida.Text = "Promocionado";
                    break;
                case 8:
                    lblsalida.Text = "Promocionado";
                    break;
                case 9:
                    lblsalida.Text = "Promocionado";
                    break;


                default:
                    break;
            }
        }
    }
}
