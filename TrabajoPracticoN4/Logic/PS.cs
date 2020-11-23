using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Logic
{
    public class PS
    {
        List<PS> listConsolasStock;
        List<PS> listaJuegosPSVenta;
        private int precio;
        private int almacenamiento;
        private string modelo;
        private int lanzamiento;
        private int codigo;


        #region CONSTRUCTORES
        /// <summary>
        /// constructor que instancia las listas genericas
        /// </summary>
        public PS()
        {
            listConsolasStock = new List<PS>();
            listaJuegosPSVenta = new List<PS>();
        }

        /// <summary>
        /// constructor que inicializa los atributos de la clase
        /// </summary>
        /// <param name="precio">precio</param>
        /// <param name="almacenamiento">almacenamiento</param>
        /// <param name="modelo">modelo</param>
        /// <param name="codigo">codigo</param>
        /// <param name="lanzamiento">lanzamiento</param>
        public PS(int precio, int almacenamiento, string modelo, int codigo, int lanzamiento)
        {
            this.precio = precio;
            this.Almacenamiento = almacenamiento;
            this.modelo = modelo;
            this.codigo = codigo;
            this.lanzamiento = lanzamiento;
        }

        #endregion

        #region METODOS

        /// <summary>
        /// metodo que valida el almacenamiento de la consola
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="almacenamiento"></param>
        /// <returns>true si es valido el almacenamiento, false si no lo es</returns>
        public bool ValidarAlcenamiento(string modelo, int almacenamiento)
        {
            
                if (modelo == "PS1" && almacenamiento == 8) 
                {
                    return true;
                }
                else if(modelo == "PS2" && almacenamiento == 4 || almacenamiento == 8 || almacenamiento == 16)
                {
                    return true;
                }
                else if(modelo == "PS3" && almacenamiento == 250 || almacenamiento == 500)
                {
                    return true;
                }
                else if (modelo == "PS4" && almacenamiento == 500 || almacenamiento == 1024)
                {
                    return true;
                }
            
            return false;
        }

        /// <summary>
        /// Carga la lista de Stock obtenida de la BD
        /// </summary>
        /// <returns></returns>
        public void CargarStockPS()
        {
            ConsolasDAO consolas = new ConsolasDAO();
            List<PS> PS = consolas.List();
            foreach (PS ps in PS)
            {
                this.listConsolasStock.Add(ps);

            }

        }

        /// <summary>
        /// Elimina las consolas agregadas al carrito
        /// </summary>
        /// <returns>true si se elimino correctamente</returns>
        public bool EliminarCarritoPS()
        {
            listaJuegosPSVenta.RemoveRange(0, this.listaJuegosPSVenta.Count);
            return true;
        }

        
        /// <summary>
        /// Muestra los datos de los juegos
        /// </summary>
        /// <param name="list">Lista de juegos</param>
        /// <returns>Retorna una cadena de texto con los datos de los juegos</returns>
        public static string MostrarDatosPS(List<PS> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (PS ps in list)
            {
                sb.AppendLine($"Codigo: {ps.Codigo}\nModelo: {ps.Modelo}\nPrecio: {ps.Precio}$\nLanzamiento: {ps.Lanzamiento}\nAlmacenamiento: {ps.Almacenamiento}\n");
            }

            return sb.ToString();
        }


        /// <summary>
        /// Muestra el stock de las consolas de PS1 en la base de datos
        /// </summary>
        /// <param name="ps">ps</param>
        /// <returns>lista de consolas</returns>
        public List<PS> StockConsolaPS1(PS ps)
        {
            //GamesDAO gamesDAO = new GamesDAO();
            //List<Games> listGames = gamesDAO.ListGames();
            List<PS> listConsolaPS1 = new List<PS>();

            foreach (PS p in ps.listConsolasStock)
            {
                if (p.Modelo == "PS1")
                {
                    listConsolaPS1.Add(p);
                }
            }
            return listConsolaPS1;
        }

        /// <summary>
        /// Muestra el stock de las consolas de PS2 en la base de datos
        /// </summary>
        /// <param name="ps">ps</param>
        /// <returns>lista de consolas</returns>
        public List<PS> StockConsolaPS2(PS ps)
        {
            //GamesDAO gamesDAO = new GamesDAO();
            //List<Games> listGames = gamesDAO.ListGames();
            List<PS> listConsolaPS2 = new List<PS>();

            foreach (PS p in ps.listConsolasStock)
            {
                if (p.Modelo == "PS2")
                {
                    listConsolaPS2.Add(p);
                }
            }
            return listConsolaPS2;
        }

        /// <summary>
        /// Muestra el stock de las consolas de PS3 en la base de datos
        /// </summary>
        /// <param name="ps">ps</param>
        /// <returns>lista de consolas</returns>
        public List<PS> StockConsolaPS3(PS ps)
        {
            //GamesDAO gamesDAO = new GamesDAO();
            //List<Games> listGames = gamesDAO.ListGames();
            List<PS> listConsolaPS3 = new List<PS>();

            foreach (PS p in ps.listConsolasStock)
            {
                if (p.Modelo == "PS3")
                {
                    listConsolaPS3.Add(p);
                }
            }
            return listConsolaPS3;
        }

        /// <summary>
        /// Muestra el stock de las consolas de PS4 en la base de datos
        /// </summary>
        /// <param name="ps">ps</param>
        /// <returns>lista de consolas</returns>
        public List<PS> StockConsolaPS4(PS ps)
        {
            //GamesDAO gamesDAO = new GamesDAO();
            //List<Games> listGames = gamesDAO.ListGames();
            List<PS> listConsolaPS4 = new List<PS>();

            foreach (PS p in ps.listConsolasStock)
            {
                if (p.Modelo == "PS4")
                {
                    listConsolaPS4.Add(p);
                }
            }
            return listConsolaPS4;
        }

        #endregion

        #region  PROPIEDADES

        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public List<PS> ListConsolasStock
        {
            get { return this.listConsolasStock; }
            set { this.listConsolasStock = value; }
        }

        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public List<PS> ListaJuegosPSVenta
        {
            get { return this.listaJuegosPSVenta; }
            set { this.listaJuegosPSVenta = value; }
        }

        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public int Lanzamiento
        {
            get { return this.lanzamiento; }
            set { this.lanzamiento = value; }
        }
        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public int Almacenamiento
        {
            get
            {
                return this.almacenamiento;

            }
            set
            {
                this.almacenamiento = value;

            }
        }
        #endregion
    }
}
