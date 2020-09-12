using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Click del btnOperar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string cmb = cmbOperador.Text;
            if ((string.IsNullOrWhiteSpace(cmbOperador.Text)) == true)
            {
                cmbOperador.Text = "+";
                MessageBox.Show("Error!!! No ha seleccionado un operador.", "Seleccione un operador.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(cmb != "+" && cmb != "-" && cmb != "*" && cmb != "/")
            {
                cmbOperador.Text = "+";
            }
            if(string.IsNullOrWhiteSpace(txtNumero1.Text) == true)
            {
                txtNumero1.Text = "0";

            }
            if(string.IsNullOrWhiteSpace(txtNumero2.Text) == true)
            {
                txtNumero2.Text = "0";
            }
            else
            {
                resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                if(resultado == double.MinValue)
                {
                    MessageBox.Show("Error!!! El divisor de la operacion no puede ser 0.", "Ingrese otro valor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string resultadoString = Convert.ToString(resultado);  
                    lblResultado.Text = resultadoString;
                }
            }
           
        }

        /// <summary>
        /// Evento Click del btnLimpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento Click del btnCerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar la calculadora?","Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        /// <summary>
        /// Evento Click del btnConvertirABinario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero(lblResultado.Text);
            string resultado = numero.DecimalBinario(lblResultado.Text);
            if(resultado == "Valor Invalido")
            {
                MessageBox.Show("El numero ingresado debe ser entero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lblResultado.Text = resultado;
            }
            
            
        }

        /// <summary>
        /// Evento Click del btnConvertirADecimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero(lblResultado.Text);
            string resultado = numero.BinarioDecimal(lblResultado.Text);
            if (resultado == "Valor Invalido.")
            {
                MessageBox.Show("El numero ingresado no es un valor en binario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lblResultado.Text = resultado;
            }
        }

        /// <summary>
        /// metodo que inicializa los textBox, label y comboBox en vacio
        /// </summary>
        public void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblResultado.Text = string.Empty;
            cmbOperador.Text = string.Empty;
        }

        /// <summary>
        /// Realiza la operacion entre los numeros pasados por parametro
        /// </summary>
        /// <param name="numero1">Numero a operar</param>
        /// <param name="numero2">Numero a operar</param>
        /// <param name="operador">Operador</param>
        /// <returns>retorna un dato de tipo double con el resultado de la operador</returns>
        public static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultado;
            resultado = Calculadora.Operar(num1,num2, operador);
            return resultado;
        }
    }
}
