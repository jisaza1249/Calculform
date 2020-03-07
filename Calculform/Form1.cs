using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculform
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }
        bool contnumeros = true, punto = true;
        string opera, borrar;
        double num1, num2, resul;
        int x = 0;

        private void boton7_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "7";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "7";
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if(contnumeros == true)
            {
                resultado.Text= "";
                resultado.Text = "8";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "8";
            }

    }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "9";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "9";
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "4";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "5";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "5";
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "6";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "6";
            }
        }

     
        private void boton1_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "1";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "1";
            };
        }


        private void boton2_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "2";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "2";
            }
        }


        private void boton3_Click(object sender, EventArgs e)
        {
            if (contnumeros == true)
            {
                resultado.Text = "";
                resultado.Text = "3";
                contnumeros = false;
            }
            else
            {
                resultado.Text = resultado.Text + "3";
            }
        }

        private void botoncero_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                return;
            }
            else
            {
                resultado.Text = resultado.Text + "0";
            }
        }

 

        private void botonigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(resultado.Text);
            if(opera=="+")
                {
                resul = num1 + num2;
                resultado.Text = resul.ToString();
                contnumeros = true;

                 }
            num2 = Convert.ToDouble(resultado.Text);
            if (opera == "*")
            {
                resul = num1 * num2;
                resultado.Text = resul.ToString();
                contnumeros = true;

            }

            num2 = Convert.ToDouble(resultado.Text);
            if (opera == "/")
            {
                resul = num1 / num2;
                resultado.Text = resul.ToString();
                contnumeros = true;

            }

            num2 = Convert.ToDouble(resultado.Text);
            if (opera == "-")
            {
                resul = num1 - num2;
                resultado.Text = resul.ToString();
                contnumeros = true;

            }
        }

        private void botonborrar_Click(object sender, EventArgs e)
        {
            borrar = resultado.Text;
            x = borrar.Length - 1;
            borrar = borrar.Substring(0, x);
            resultado.Text = borrar;

            if (resultado.Text == "")
            {
                resultado.Text = "0";
                contnumeros = true;
            }
            if (resultado.Text == "-")
            {
                resultado.Text = "0";
                contnumeros = true;
            }
        }

        private void Botonpunto_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                resultado.Text = resultado.Text + ".";
                punto = false;
            }
            else
            {
                return;
            }
        }
        private void botonmult_Click(object sender, EventArgs e)
            {
            opera = "*";
            num1 = Convert.ToDouble(resultado.Text);
            contnumeros = true;

        }
        private void botondiv_Click(object sender, EventArgs e)
        {
            opera = "/";
            num1 = Convert.ToDouble(resultado.Text);
            contnumeros = true;
        }
        private void botonmas_Click(object sender, EventArgs e)
        {
            opera = "+";
            num1 = Convert.ToDouble(resultado.Text);
            contnumeros = true;
        }
        private void botonmenos_Click(object sender, EventArgs e)
        {
            opera = "-";
            num1 = Convert.ToDouble(resultado.Text);
            contnumeros = true;
        }
    }

}