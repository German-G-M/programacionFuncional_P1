using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_en_cSharp
{
    public partial class Form1 : Form
    {
        float valor, valor1; //el valor inicial de la calculdora
        bool s, r, m, d, operacion;
        public Form1()
        {
            InitializeComponent();
            valor = 0; //inicializamos con "0" el primer elemento
            valor1 = 0; //inicializamos con "0" el segundo elemento
            s = false;
            r = false;
            m = false;
            d = false;
            operacion = false;
        }
        private float Suma(float a, float b){return a + b;}
        private float Resta(float a, float b){return a - b;}
        private float Multiplicacion(float a, float b){return a * b;}
        private float Division(float a, float b){return a / b;}
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {   //este es el botón para sumar (+)
            valor1 = valor;
            s = true;
            operacion = true;
        }
        private void Button13_Click(object sender, EventArgs e)
        {   //este es el botón para restar (-)
            valor1 = valor;
            r = true;
            operacion = true;
        }
        private void Button14_Click(object sender, EventArgs e)
        {   //este es el botón para multiplicar (X)
            valor1 = valor;
            m = true;
            operacion = true;
        }
        private void Button15_Click(object sender, EventArgs e)
        {   //este es el botón para dividir (/)
            valor1 = valor;
            d = true;
            operacion = true;
        }

        private void Button17_Click(object sender, EventArgs e)
        {    //este boton limpia o pone en "0" el TextBox
            valor = 0;
            textBox1.Text = valor.ToString();
        }
        private void Button1_Click(object sender, EventArgs e)
        {   //este maneja todos lo botones con el método "click"
            if (operacion == true) {
                valor = 0;
            }
                valor = valor * 10 + Convert.ToInt32(((Button)sender).Text);// mandamos el nombre del boton al "textbox" y concatenamos
                textBox1.Text = valor.ToString();//volvemos a string para mostrar en el "textbox"
                operacion = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {//este boton es el "=" 
            float a;
            if(s==true)
            {
                a = Suma(valor1, valor);
                textBox1.Text = a.ToString();//sumamos y mostramos en el "textbox1"
                valor = a; //le ponemos a valor para que se pueda tambíen operar este resultado
                s = false;
            }
            if (r == true)
            {
                a = Resta(valor1, valor);
                textBox1.Text = a.ToString();//restamos y mostramos en el "textbox1"
                valor = a; //le ponemos a valor para que se pueda tambíen operar este resultado
                r = false;
            }
            if (m == true)
            {
                a = Multiplicacion(valor1, valor);
                textBox1.Text = a.ToString();//multiplicamos y mostramos en el "textbox1"
                valor = a; //le ponemos a valor para que se pueda tambíen operar este resultado
                m = false;
            }
            if (d == true)
            {
                a = Division(valor1, valor);
                textBox1.Text = a.ToString();//multiplicamos y mostramos en el "textbox1"
                valor = a; //le ponemos a valor para que se pueda tambíen operar este resultado
                d = false;
            }


        }
    }
}
