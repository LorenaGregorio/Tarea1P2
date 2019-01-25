using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1CalculadoraUDEO
{
    public partial class Form1 : Form
    {


        // SE DECLARARON LAS VARIABLES DE USO PARA LAS OPERACIONES
        // SE DECLARARON PUBLICAS PARA QUE SE PUEDAN USAR EN TODO EL PROGRAMA
        // SE INICIALIZO EL VALOR DE LA VARIABLES SEGUN SU TIPO
        public string valorInicial = "";
        public string valorFinal = "";
        public string signoActual = "";
        public int contadorCalculos = 0;

        public Form1()
        {
            InitializeComponent();
        }



        //limpiar pantalla
        private void btnC_Click_1(object sender, EventArgs e)
        {
            ReiniciarValores();
            PANTALLA.Text = "";
        }
        
        //sustituye el valor de la variable valor inicial y
        // le agrega el valor de la viriable valor
        //para luego luego mostrarlo en pantalla

        public void AgregarValorInicial(string valor)
        {
            valorInicial += valor;
            PANTALLA.Text = valorInicial.ToString();
        }

        //sustituye el valor de la variable valor inicial y
        // le agrega el valor de la viriable valor
        //para luego luego mostrarlo en pantalla
        public void agregarValorFinal(string valor)
        {
            valorFinal += valor;
            PANTALLA.Text = valorFinal.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

       

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("1");
            }
            else
            {
                agregarValorFinal("1");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("2");
            }
            else
            {
                agregarValorFinal("2");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("3");
            }
            else
            {
                agregarValorFinal("3");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("4");
            }
            else
            {
                agregarValorFinal("4");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("5");
            }
            else
            {
                agregarValorFinal("5");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("6");
            }
            else
            {
                agregarValorFinal("6");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("7");
            }
            else
            {
                agregarValorFinal("7");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("8");
            }
            else
            {
                agregarValorFinal("8");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("9");
            }
            else
            {
                agregarValorFinal("9");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((signoActual != "") && (contadorCalculos == 0))
            {
                AgregarValorInicial("0");
            }
            else
            {
                agregarValorFinal("0");
            }
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            signoActual = "+";
            PANTALLA.Text = "";
        }

        private void btnmen_Click(object sender, EventArgs e)
        {
            signoActual = "-";
            PANTALLA.Text = "";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            signoActual = "*";
            PANTALLA.Text = "";
        }

        private void btndivi_Click(object sender, EventArgs e)
        {

            signoActual = "/";
            PANTALLA.Text = "";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            switch (signoActual)
            {
                case "+":
                    resultado = Convert.ToDouble(valorInicial) + Convert.ToDouble(valorFinal);
                    PANTALLA.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = Convert.ToDouble(valorInicial) * Convert.ToDouble(valorFinal);
                    PANTALLA.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = Convert.ToDouble(valorFinal) - Convert.ToDouble(valorInicial);
                    PANTALLA.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = Convert.ToDouble(valorInicial) / Convert.ToDouble(valorFinal);
                    PANTALLA.Text = resultado.ToString();
                    break;
            }

            valorInicial = resultado.ToString();
            signoActual = "";
            valorFinal = "";
            contadorCalculos += 1;
        }


        // SE DECLARO UN METODO PARA REINICIAR LOS VALORES DE LA CALCULADORA

        private void ReiniciarValores()
        {
            signoActual = "";
            valorInicial = "";
            valorFinal = "";
            contadorCalculos = 0;
        }
        //  SE DECLARO METODO PARA ACCIONAR TECLADO DE MAQUINA 

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Convert.ToInt16(e.KeyChar))
            {
                case 42:
                    signoActual = "*";

                    break;
                case 43:
                    signoActual = "+";
                    PANTALLA.Text = "";
                    break;
                case 45:
                    signoActual = ".";
                    break;
                case 46:
                    signoActual ="-";
                    break;
                case 47:
                    signoActual = "/";
                    break;
                case 48:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("0");
                    }
                    else
                    {
                        agregarValorFinal("0");
                    }
                    break;

                case 49:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("1");
                    }
                    else
                    {
                        agregarValorFinal("1");
                    }
                    break;
                case 50:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("2");
                    }
                    else
                    {
                        agregarValorFinal("2");
                    }
                    break;
                case 51:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("3");
                    }
                    else
                    {
                        agregarValorFinal("3");
                    }
                    break;
                case 52:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("4");
                    }
                    else
                    {
                        agregarValorFinal("4");
                    }
                    break;
                case 53:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("5");
                    }
                    else
                    {
                        agregarValorFinal("5");
                    }
                    break;
                case 54:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("6");
                    }
                    else
                    {
                        agregarValorFinal("6");
                    }
                    break;
                case 55:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("7");
                    }
                    else
                    {
                        agregarValorFinal("7");
                    }
                    break;
                case 56:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("8");
                    }
                    else
                    {
                        agregarValorFinal("8");
                    }

                    break;
                case 57:
                    if ((signoActual != "") && (contadorCalculos == 0))
                    {
                        AgregarValorInicial("9");
                    }
                    else
                    {
                        agregarValorFinal("9");
                    }
                    break;





            }

        }
    }
       
}
