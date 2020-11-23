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
using System.Threading;
using Excepciones;

namespace PolaStation
{
    public partial class FormGames : Form
    {
        private Games games;
        private PS ps;
        private List<Thread> threads;
        Cliente cliente;
        public FormGames()
        {
            InitializeComponent();
            games = new Games();
            ps = new PS();
            cliente = new Cliente();

            //THREADS
            threads = new List<Thread>();
            Thread threadGames = new Thread(games.CargarStock);
            Thread threadPS = new Thread(ps.CargarStockPS);
            threads.Add(threadGames);
            threads.Add(threadPS);
            //EVENTOS
            this.games.NewEvent += BorrarCarrito1_Click;
            this.games.NewEvent += BorrarCarrito2_Click;

            btnGenerarFactura.Enabled = false;

        }
        private void FormGames_Load(object sender, EventArgs e)
        {
            foreach (Thread t in this.threads)
            {
                t.Start();
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //GamesDAO Games = new GamesDAO();
            List<Games> gamesPS1 = new List<Games>();
            List<Games> gamesPS2 = new List<Games>();
            List<Games> gamesPS3 = new List<Games>();
            List<Games> gamesPS4 = new List<Games>();
            List<Games> gamesTodos = new List<Games>();
            string modelo = cmbModelo.Text;
            switch(modelo)
            {
                case "PS1":
                    if (radiobtnDigital.Checked)
                    {
                        MessageBox.Show("No hay juegos digitales de PS2 disponibles");
                    }
                    else
                    {
                        gamesPS1 = games.StockPS1(games);
                        MostrarBD mostrarPS1 = new MostrarBD(gamesPS1);
                        mostrarPS1.ShowDialog();
                    }
                    
                    break;
                case "PS2":
                    if (radiobtnDigital.Checked)
                    {
                        MessageBox.Show("No hay juegos digitales de PS2 disponibles");
                    }
                    else
                    {
                        gamesPS2 = games.StockPS2(games);
                        MostrarBD mostrarPS2 = new MostrarBD(gamesPS2);
                        mostrarPS2.ShowDialog();
                    }
                    
                    break;
                case "PS3":
                    if (radiobtnDigital.Checked)
                    {
                        gamesPS3 = games.StockPS3Digital(games);
                        MostrarBD mostrarPS3 = new MostrarBD(gamesPS3);
                        mostrarPS3.ShowDialog();
                    }
                    else if(radiobtnFisico.Checked)
                    {
                        gamesPS3 = games.StockPS3Fisico(games);
                        MostrarBD mostrarPS3 = new MostrarBD(gamesPS3);
                        mostrarPS3.ShowDialog();
                    }
                    else
                    {
                        gamesPS3 = games.StockPS3(games);
                        MostrarBD mostrarPS3 = new MostrarBD(gamesPS3);
                        mostrarPS3.ShowDialog();
                    }
                    break;
                case "PS4":
                    if (radiobtnDigital.Checked)
                    {
                        gamesPS4 = games.StockPS4Digital(games);
                        MostrarBD mostrarPS4 = new MostrarBD(gamesPS4);
                        mostrarPS4.ShowDialog();
                    }
                    else if (radiobtnFisico.Checked)
                    {
                        gamesPS4 = games.StockPS4Fisico(games);
                        MostrarBD mostrarPS4 = new MostrarBD(gamesPS4);
                        mostrarPS4.ShowDialog();
                    }
                    else
                    {
                        gamesPS4 = games.StockPS4(games);
                        MostrarBD mostrarPS4 = new MostrarBD(gamesPS4);
                        mostrarPS4.ShowDialog();
                    }
                    break;
                default:
                    gamesTodos = games.Stock;
                    MostrarBD mostrarTodo = new MostrarBD(gamesTodos);
                    mostrarTodo.ShowDialog();
                    break;
            }
            
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.label1.Text = DateTime.Now.ToString();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            string nombreJuego = txtNombre.Text;
            string modelo = cmbModelo.Text;
            Games.EFormato formato = Games.EFormato.Fisico;
            //GamesDAO games = new GamesDAO();
            List<Games> games1 = games.Stock;
            if (radiobtnDigital.Checked)
            {
                formato = Games.EFormato.Digital;
            }
            else if(radiobtnFisico.Checked)
            {
                formato = Games.EFormato.Fisico;
            }
            foreach (Games g in games1)
            {
                if (g.Nombre == nombreJuego && g.Plataforma == modelo && g.Formato == formato)
                {
                    
                    Games game1 = new Games(g.Precio, g.Lanzamiento, g.Nombre, g.Codigo, g.Formato, g.Plataforma);
                    games.ListaJuegos.Add(game1);
                    
                    richTextBox1.Text = (Games.MostrarDatos(games.ListaJuegos));         
                    break;


                }
                
            }
            if (!games.ValidarPlataforma(modelo))
            {
                MessageBox.Show("La plataforma ingresada es invalida");
            }
            if (!games.ValidarNombre(nombreJuego))
            {
                MessageBox.Show("El nombre del juego es invalido o no esta en Stock");
            }

        }

        public void ExecuteProgressBar()
        {
            while (progressBar.Value < 100)
            {
                if (progressBar.Value < 100)
                {
                    progressBar.Value += 10;
                }
                else if (progressBar.Value == 100)
                {
                    break;
                }
                Thread.Sleep(100);

            }
            DialogResult dr = MessageBox.Show("Se ha eliminado todos los productos del carrito");
            if (dr == DialogResult.OK)
            {
                progressBar.Value = 0;
            }
        }
        private void BorrarCarrito1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();       
            games.EliminarCarrito();
            rtb2.Clear();
            this.ExecuteProgressBar();
            
            
       
        }
        private void BorrarCarrito2_Click(object sender, EventArgs e)
        {

            ps.EliminarCarritoPS();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (games.ListaJuegos.Count == 0 && ps.ListaJuegosPSVenta.Count == 0)
            {
                MessageBox.Show("No se han agregado elementos al carrito");
            }
            else
            {
                int gameInt = 0;
                int psInt = 0;
                int precioTotalJuegos = gameInt.ObtenerPrecioJuegos(games);
                int precioTotalConsolas = psInt.ObtenerPrecioTotalConsolas(ps);
                int precioTotal = precioTotalConsolas + precioTotalJuegos;

                try
                {
                    FormCliente formCliente = new FormCliente(precioTotal, this);
                    formCliente.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (games.ListaJuegos.Count > 1)
                    {
                        games.ListaJuegos.RemoveAt(games.ListaJuegos.Count);

                    }
                    if (ps.ListaJuegosPSVenta.Count > 0)
                    {
                        ps.ListaJuegosPSVenta.RemoveAt(ps.ListaJuegosPSVenta.Count - 1);

                    }


                }

                lblprecioTotal.Text = precioTotal.ToString();
                richTextBox1.Clear();
                rtb2.Clear();
                btnGenerarFactura.Enabled = true;
            }
            
            
        }

        private void StockPS_Click(object sender, EventArgs e)
        {
            List<PS> ConsolaPS1 = new List<PS>();
            List<PS> ConsolaPS2 = new List<PS>();
            List<PS> ConsolaPS3 = new List<PS>();
            List<PS> ConsolaPS4 = new List<PS>();
            if (rdbPS1.Checked == false && rdbPS2.Checked == false && rdbPS3.Checked == false && rdbPS4.Checked == false)
            {
                MostrarConsolas mostrar = new MostrarConsolas(ps.ListConsolasStock);
                mostrar.ShowDialog();
            }
            else
            {
                if (rdbPS1.Checked)
                {
                    ConsolaPS1 = ps.StockConsolaPS1(ps);
                    MostrarConsolas mostrarPS1 = new MostrarConsolas(ConsolaPS1);
                    mostrarPS1.ShowDialog();
                }
                if (rdbPS2.Checked)
                {
                    ConsolaPS2 = ps.StockConsolaPS2(ps);

                    MostrarConsolas mostrarPS2 = new MostrarConsolas(ConsolaPS2);
                    mostrarPS2.ShowDialog();
                }
                if (rdbPS3.Checked)
                {
                    ConsolaPS3 = ps.StockConsolaPS3(ps);

                    MostrarConsolas mostrarPS3 = new MostrarConsolas(ConsolaPS3);
                    mostrarPS3.ShowDialog();
                }
                if (rdbPS4.Checked)
                {
                    ConsolaPS4 = ps.StockConsolaPS4(ps);

                    MostrarConsolas mostrarPS4 = new MostrarConsolas(ConsolaPS4);
                    mostrarPS4.ShowDialog();
                }
            }
            
        }

        private void btnCarritoConsola_Click(object sender, EventArgs e)
        {
            bool valor = false;
            string almacenamiento = cmbPS.Text;
            int almac;
            int.TryParse(almacenamiento, out almac);
            string modelo = "";
            if (rdbPS1.Checked)
            {
                modelo = "PS1";
            }
            if (rdbPS2.Checked)
            {
                modelo = "PS2";
            }
            if (rdbPS3.Checked)
            {
                modelo = "PS3";
            }
            if (rdbPS4.Checked)
            {
                modelo = "PS4";
            }

            foreach (PS p in ps.ListConsolasStock)
            {
                if (p.Modelo == modelo && ps.ValidarAlcenamiento(modelo, almac))
                {
                    PS polastation = new PS(p.Precio, almac, modelo, p.Codigo, p.Lanzamiento);
                    ps.ListaJuegosPSVenta.Add(polastation);
                    rtb2.Text = (PS.MostrarDatosPS(ps.ListaJuegosPSVenta));
                    valor = true;
                    break;


                }
                

            }
            if (valor == false)
            {
                MessageBox.Show("El almacenamiento indicado para esta consola no esta disponible");

            }
        }

        

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            ArchivoTexto texto = new ArchivoTexto();
            ArchivosXml<Games> xmlGames = new ArchivosXml<Games>();
            ArchivosXml<PS> xmlConsola = new ArchivosXml<PS>();
            foreach (Games g in games.ListaJuegos)
            {
                texto.GuardarArchivoTexto("FacturaJuegos.txt", Games.MostrarDatos(games.ListaJuegos),false);
                xmlGames.Guardar("Juegos.xml", g);
            }
            foreach (PS p in ps.ListaJuegosPSVenta)
            {
                texto.GuardarArchivoTexto("FacturaConsolas.txt", PS.MostrarDatosPS(ps.ListaJuegosPSVenta),false);
                xmlConsola.Guardar("Consola.xml", p);
            }
            MessageBox.Show("Factura creada con exito");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            games.LanzarEvento();
        }

        private void form_Closing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread t in this.threads)
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }
        }

        
    }
}
