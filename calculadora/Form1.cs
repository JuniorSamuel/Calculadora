using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal contenedor;
        decimal temp;
        String signo;
        decimal memoria;
        bool op; 
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            contenedor = 0;
            temp = 0;
            signo = "";
            txPrincipal.Text = "0";
            txSecundario.Text = "";
        }

        private void btCero_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "0";
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "1";
        }

        private void btDos_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "3";
        }

        private void btCuatro_Click(object sender, EventArgs e)
        {
            txPrincipal.Text += "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "6";
        }

        private void btSiete_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "7";
        }

        private void btOcho_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "8";
        }

        private void btNueve_Click(object sender, EventArgs e)
        {
            izCero();
            txPrincipal.Text += "9";
        }

        private void txPrincipal_TextChanged(object sender, EventArgs e)
        {

        }
        private void izCero() //Evaluea que valida que existan cero a la izquienda
        {
            if (txPrincipal.Text == "0" || op == true)
            {
                txPrincipal.Text = "";
                op = false;
            }
        }
        private void vista(String signo)
        {
            temp = Decimal.Parse(txPrincipal.Text);
            txSecundario.Text += txPrincipal.Text + " " + signo + " ";
            op = true;
        }

        private void operacion(String signo)
        {
            this.signo = signo;
            vista(signo);
            if (!primeraValor())
            {
                switch (signo)
                {
                    case "+":
                        temp = Decimal.Parse(txPrincipal.Text);
                        contenedor += temp;
                        break;
                    case "-":
                        temp = Decimal.Parse(txPrincipal.Text);
                        contenedor -= temp;
                        break;
                    case "*":
                        temp = Decimal.Parse(txPrincipal.Text);
                        contenedor *= temp;
                        break;
                    case "/":
                        temp = Decimal.Parse(txPrincipal.Text);
                        try
                        {
                            contenedor /= temp;
                        }
                        catch (DivideByZeroException)
                        {
                            txPrincipal.Text = "0";
                            txSecundario.Text = "No se puede dividir entre 0";
                        }

                        break;
                }
                txPrincipal.Text = contenedor+"";
            }            
        }

        private void btSuma_Click(object sender, EventArgs e)
        {      
            operacion("+");
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            operacion("-");        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion("*");
        }

        private void btDivicion_Click(object sender, EventArgs e)
        {           
            operacion("/");
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            txPrincipal.Text += ".";
        }

        private void btIgual_Click(object sender, EventArgs e) //Boton Igual =
        {

            operacion(signo);            
            txPrincipal.Text = contenedor + "";
            contenedor = 0;
            txSecundario.Text = "";
            op = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txPrincipal.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memoria = Decimal.Parse(txPrincipal.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txPrincipal.Text = memoria+"";
        }
        private bool primeraValor()
        {
            if (contenedor == 0)
            {
                contenedor = temp;
                return true;
            }
            return false;
        }
    }
}
