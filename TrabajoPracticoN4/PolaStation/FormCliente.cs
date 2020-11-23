using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Excepciones;
namespace PolaStation
{
    public partial class FormCliente : Form
    {
        int precioTotal;
        public FormGames frmGames;
        public Cliente cliente;
        public FormCliente(int precio, FormGames frmGames1)
        {
            precioTotal = precio;
            frmGames = frmGames1;

            InitializeComponent();
        }

        public void CargarCliente(int totalCompra)
        {
            string nombre = txtNombreCliente.Text;
            string dni = txtDni.Text;

            EMedioDePago medio = EMedioDePago.efectivo;
            if (rdbEfectivo.Checked)
            {
                medio = EMedioDePago.efectivo;
            }
            if (rdbTarjeta.Checked)
            {
                medio = EMedioDePago.efectivo;
            }

            cliente = new Cliente(nombre, dni, medio, totalCompra);
            cliente.Clientes.Add(cliente);

        }

        private void btnComprarCliente_Click(object sender, EventArgs e)
        {
            CargarCliente(precioTotal);
            DialogResult d = MessageBox.Show("Compra realizada", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            cliente.CargarClientesArchivoTexto();
            this.Close();
            if (d == DialogResult.OK)
            {
                frmGames.ExecuteProgressBar();
            }
        }
    }
}
