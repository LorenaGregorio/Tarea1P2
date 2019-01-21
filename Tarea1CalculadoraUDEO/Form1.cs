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
        public Form1()
        {
            InitializeComponent();
        }

        // SE DECLARARON LAS VARIABLES DE USO PARA LAS OPERACIONES
        // SE DECLARARON PUBLICAS PARA QUE SE PUEDAN USAR EN TODO EL PROGRAMA
        // SE INICIALIZO EL VALOR DE LA VARIABLES SEGUN SU TIPO
        public string valorInicial = "";
        public string valorFinal = "";
        public string signoActual = "";
        public int contadorCalculos = 0;

        // SE DECLARO UN METODO PARA REINICIAR LOS VALORES DE LA CALCULADORA

        private void ReiniciarValores()
        {
            signoActual = "";
            valorInicial = "";
            valorFinal = "";
            contadorCalculos = 0;
        }

        // 
        public void AgregarValorInicial(string valor)
        {
            valorInicial += valor;
            PANTALLA.Text = valorInicial.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ReiniciarValores();
            PANTALLA.Text = "";

        }
    }
}
