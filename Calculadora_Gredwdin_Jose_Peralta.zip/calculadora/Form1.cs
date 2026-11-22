using System;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        string operacion = "";
        bool nuevoNumero = true;

        public Form1()
        {
            InitializeComponent();

            // Botones numericos
            btn0.Click += Numero_Click;
            btn1.Click += Numero_Click;
            btn2.Click += Numero_Click;
            btn3.Click += Numero_Click;
            btn4.Click += Numero_Click;
            btn5.Click += Numero_Click;
            btn6.Click += Numero_Click;
            btn7.Click += Numero_Click;
            btn8.Click += Numero_Click;
            btn9.Click += Numero_Click;

            // Botones de operaciones
            btnSumar.Click += Operacion_Click;
            btnRestar.Click += Operacion_Click;
            btnMultiplicar.Click += Operacion_Click;
            btnDividir.Click += Operacion_Click;

            // Otros botones
            btnIgual.Click += Igual_Click;
            btnClear.Click += Clear_Click;
            btnBackspace.Click += Backspace_Click;
            btnBinario.Click += Binario_Click;
            btnHex.Click += Hex_Click;
        }

        // Introducir numeros
        private void Numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero || textBotxtpantalla.Text == "0")
            {
                textBotxtpantalla.Text = boton.Text;
                nuevoNumero = false;
            }
            else
            {
                textBotxtpantalla.Text += boton.Text;
            }
        }

        // Seleccionar operacion
        private void Operacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            primerNumero = Convert.ToDouble(textBotxtpantalla.Text);

            if (boton.Name == "btnMultiplicar")
            {
                operacion = "*";
            }
            else
            {
                operacion = boton.Text.Trim();
            }

            nuevoNumero = true;
        }

        // Calcular resultado
        private void Igual_Click(object sender, EventArgs e)
        {
            double segundoNumero;
            double resultado = 0;

            segundoNumero = Convert.ToDouble(textBotxtpantalla.Text);

            if (operacion == "+")
            {
                resultado = primerNumero + segundoNumero;
            }
            else if (operacion == "-")
            {
                resultado = primerNumero - segundoNumero;
            }
            else if (operacion == "*")
            {
                resultado = primerNumero * segundoNumero;
            }
            else if (operacion == "/")
            {
                if (segundoNumero == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                    return;
                }

                resultado = primerNumero / segundoNumero;
            }
            else
            {
                return;
            }

            textBotxtpantalla.Text = resultado.ToString();

            nuevoNumero = true;
            operacion = "";
        }

        // Limpiar pantalla
        private void Clear_Click(object sender, EventArgs e)
        {
            textBotxtpantalla.Text = "0";

            primerNumero = 0;
            operacion = "";
            nuevoNumero = true;
        }

        // Borrar ultimo caracter
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (textBotxtpantalla.Text.Length > 1)
            {
                textBotxtpantalla.Text =
                    textBotxtpantalla.Text.Substring(
                    0, textBotxtpantalla.Text.Length - 1);
            }
            else
            {
                textBotxtpantalla.Text = "0";
            }
        }

        // Convertir a binario
        private void Binario_Click(object sender, EventArgs e)
        {
            long numero;

            if (long.TryParse(textBotxtpantalla.Text, out numero)
                && numero >= 0)
            {
                textBotxtpantalla.Text =
                    Convert.ToString(numero, 2);

                nuevoNumero = true;
            }
            else
            {
                MessageBox.Show("Ingrese un numero entero positivo.");
            }
        }

        // Convertir a hexadecimal
        private void Hex_Click(object sender, EventArgs e)
        {
            long numero;

            if (long.TryParse(textBotxtpantalla.Text, out numero)
                && numero >= 0)
            {
                textBotxtpantalla.Text =
                    Convert.ToString(numero, 16).ToUpper();

                nuevoNumero = true;
            }
            else
            {
                MessageBox.Show("Ingrese un numero entero positivo.");
            }
        }

        // Eventos anteriores del diseñador
        private void textBotxtpantalla_TextChanged(object sender, EventArgs e) { }

        private void btn7_Click(object sender, EventArgs e) { }
        private void btn8_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void button8_Click(object sender, EventArgs e) { }
        private void button9_Click(object sender, EventArgs e) { }
        private void btn0_Click(object sender, EventArgs e) { }
        private void button14_Click(object sender, EventArgs e) { }
        private void button3_Click_1(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}