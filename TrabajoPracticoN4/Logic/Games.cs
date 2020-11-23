using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Logic
{
    public delegate void NewDelegate(object sender, EventArgs e);
    public class Games
    {
        public event NewDelegate NewEvent;
        public enum EFormato { Digital, Fisico }
        private List<Games> stock;
        private List<Games> listaJuegos;
        private int precio;
        private int lanzamiento;
        private string nombre;
        private int codigo;
        private EFormato formato;
        private string online;
        private string plataforma;
        #region CONSTRUCTORES

        /// <summary>
        /// Constructor que inicializa la lista de juegos y el stock
        /// </summary>
        public Games()
        {
            stock = new List<Games>();
            listaJuegos = new List<Games>();
        }

        /// <summary>
        /// Constructor que inicializa los atributos de la clase
        /// </summary>
        /// <param name="precio">precio del juego</param>
        /// <param name="lanzamiento">fecha de lanzamiento</param>
        /// <param name="nombre">nombre</param>
        /// <param name="codigo">codigo</param>
        /// <param name="formato">formato</param>
        /// <param name="plataforma">plataforma</param>
        public Games(int precio, int lanzamiento, string nombre, int codigo, EFormato formato,string plataforma) :this()
        {
            this.Precio = precio;
            this.Lanzamiento = lanzamiento;
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Formato = formato;
            this.Plataforma = plataforma;
        }

        /// <summary>
        /// Constructor que inicializa los atributos de la clase
        /// </summary>
        /// <param name="precio">precio del juego</param>
        /// <param name="lanzamiento">fecha de lanzamiento</param>
        /// <param name="nombre">nombre</param>
        /// <param name="codigo">codigo</param>
        /// <param name="formato">formato</param>
        /// <param name="plataforma">plataforma</param>
        /// /// <param name="online">online</param>
        public Games(int precio, int lanzamiento, string nombre, int codigo, EFormato formato, string plataforma,string online) : this()
        {
            this.Precio = precio;
            this.Lanzamiento = lanzamiento;
            this.nombre = nombre;
            this.Codigo = codigo;
            this.Formato = formato;
            this.Plataforma = plataforma;
            this.online = online;
        }
        #endregion

        #region METODOS

        /// <summary>
        /// metodo que lanza el evento
        /// </summary>
        public void LanzarEvento()
        {
            if (this.NewEvent != null)
            {
                this.NewEvent.Invoke(this,new EventArgs());

            }
        }
        /// <summary>
        /// Carga la lista de Stock obtenida de la BD
        /// </summary>
        /// <returns></returns>
        public void CargarStock()
        {
            GamesDAO games = new GamesDAO();
            Games game = new Games();
            List<Games> lista = games.List();
            foreach (Games item in lista)
            {
                this.Stock.Add(item);
            }
        }
        /// <summary>
        /// Muestra los datos de los juegos
        /// </summary>
        /// <param name="list">Lista de juegos</param>
        /// <returns>Retorna una cadena de texto con los datos de los juegos</returns>
        public static string MostrarDatos(List<Games> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Games g in list)
            {
                sb.AppendLine($"Codigo: {g.Codigo}\nNombre: {g.Nombre}\nPrecio: {g.Precio}$\nLanzamiento: {g.Lanzamiento}\nFormato: {g.Formato}\nPlataforma: {g.Plataforma}\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Elimina todos los productos del carrito
        /// </summary>
        /// <returns>Retorna true,todo ok</returns>
        public bool EliminarCarrito()
        {
            listaJuegos.RemoveRange(0, this.listaJuegos.Count);
            return true;

        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS1
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS1(Games game)
        {
            List<Games> listGamesPS1 = new List<Games>();

            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS1")
                {
                    listGamesPS1.Add(g);
                }
            }
            return listGamesPS1;
        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS2
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS2(Games game)
        {
            List<Games> listGamesPS2 = new List<Games>();

            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS2")
                {
                    listGamesPS2.Add(g);
                }
            }
            return listGamesPS2;
        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS3
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS3(Games game)
        {
            List<Games> listGamesPS3 = new List<Games>();

            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS3")
                {
                    listGamesPS3.Add(g);
                }
            }
            return listGamesPS3;
        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS3 digitales
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS3Digital(Games game)
        {
            List<Games> listGamesPS3 = new List<Games>();

            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS3" && g.Formato == EFormato.Digital)
                {
                    listGamesPS3.Add(g);
                }
            }
            return listGamesPS3;
        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS3 fisicos
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS3Fisico(Games game)
        {
            List<Games> listGamesPS3 = new List<Games>();

            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS3" && g.Formato == EFormato.Fisico)
                {
                    listGamesPS3.Add(g);
                }
            }
            return listGamesPS3;
        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS4 
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS4(Games game)
        {

            List<Games> listGamesPS4 = new List<Games>();

            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS4")
                {
                    listGamesPS4.Add(g);
                }
            }
            return listGamesPS4;
        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS4 digitales
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS4Digital(Games game)
        {
            List<Games> listGamesPS4 = new List<Games>();
            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS4" && g.Formato == EFormato.Digital)
                {
                    listGamesPS4.Add(g);
                }
            }
            return listGamesPS4;
        }

        /// <summary>
        /// Obtiene una lista con los juegos de PS4 fisicos
        /// </summary>
        /// <returns>Retorna a una lista con los juegos</returns>
        public List<Games> StockPS4Fisico(Games game)
        {
            List<Games> listGamesPS4 = new List<Games>();
            foreach (Games g in game.Stock)
            {
                if (g.Plataforma == "PS4" && g.Formato == EFormato.Fisico)
                {
                    listGamesPS4.Add(g);
                }
            }
            return listGamesPS4;
        }

        /// <summary>
        /// Metodo que valida la plataforma
        /// </summary>
        /// <param name="plataforma">plataforma a validar</param>
        /// <returns>return true si la plataforma es correcta, false si es incorrecta</returns>
        public bool ValidarPlataforma(string plataforma)
        {
            if (plataforma == "PS1" || plataforma == "PS2" || plataforma == "PS3" || plataforma == "PS4")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo que valida el nombre
        /// </summary>
        /// <param name="plataforma">nombre a validar</param>
        /// <returns>return true si el nombre es correcto, false si es incorrecto</returns>
        public bool ValidarNombre(string nombreJuego)
        {
            bool retorno = false;
            foreach (Games g in this.Stock)
            {
                if (g.Nombre == nombreJuego)
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura y escritura 
        /// </summary>
        public List<Games> ListaJuegos
        {
            get { return this.listaJuegos; }
            set { this.listaJuegos = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura 
        /// </summary>
        public List<Games> Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura 
        /// </summary>
        public int Lanzamiento
        {
            get { return this.lanzamiento; }
            set { this.lanzamiento = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura 
        /// valida la plataforma
        /// </summary>
        public string Plataforma
        {
            get
            {
                if (ValidarPlataforma(this.plataforma))
                {
                    return this.plataforma;
                }
                else
                {
                    throw new PlataformaInvalidaException("La plataforma es invalida");
                }     
            }
            set
            {
                if (ValidarPlataforma(value))
                {
                    this.plataforma = value;
                }
                else
                {
                    throw new PlataformaInvalidaException("La plataforma es invalida");
                }
            }
        }
        

        /// <summary>
        /// Propiedad de lectura y escritura 
        /// </summary>
        public EFormato Formato
        {
            get { return this.formato; }
            set { this.formato = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura 
        /// </summary>
        public int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura 
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura 
        /// </summary>
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        #endregion

    }
}
