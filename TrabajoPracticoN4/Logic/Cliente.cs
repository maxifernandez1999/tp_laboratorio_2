using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Logic
{
    public enum EMedioDePago { tarjeta, efectivo}
    public class Cliente
    {
        private string nombre;
        private string dni;
        private EMedioDePago medioDePago;
        private List<Cliente> clientes;
        private int totalCompra;

        #region CONSTRUCTORES
        /// <summary>
        /// constructor por defecto sin parametros
        /// </summary>
        public Cliente()
        {
            clientes = new List<Cliente>();
        }

        /// <summary>
        /// constructor que inicializa los atributos de cliente
        /// </summary>
        /// <param name="nombre">nombre</param>
        /// <param name="dni">dni</param>
        /// <param name="medioDePago">medio de pago</param>
        /// <param name="totalCompra">total de la compra</param>
        public Cliente(string nombre, string dni, EMedioDePago medioDePago, int totalCompra) : this()
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.MedioDePago = medioDePago;
            this.totalCompra = totalCompra;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// metodo que carga los clientes en un archivo de texto
        /// </summary>
        public void CargarClientesArchivoTexto()
        {
            ArchivoTexto t = new ArchivoTexto();
            t.GuardarArchivoTexto("ListaClientes.txt", this.MostrarClientes(), true);
        }

        /// <summary>
        /// metodo que muestra los clientes
        /// </summary>
        /// <returns></returns>
        public string MostrarClientes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente c in this.Clientes)
            {
                sb.AppendLine($"Nombre:{this.Nombre}");
                sb.AppendLine($"Nombre:{this.Dni}");
                sb.AppendLine($"Nombre:{this.MedioDePago}");
            }
            return sb.ToString();
            

        }

        /// <summary>
        /// metodo que valida que el nombre contenga unicamente caracteres valido
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public bool ValidarNombre(string nombre)
        {
            bool retorno = false;
            foreach (char c in nombre)
            {
                if (char.IsLetter(c))
                {
                    retorno = true;

                }
                else
                {
                    retorno = false;
                    break;
                }
                
            }
            return retorno;
        }

        /// <summary>
        /// valida que el dni sea numerico
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public bool ValidarDni(string dni)
        {
            int dniEntero = 0;
            if (int.TryParse(dni, out dniEntero))
            {
                if (dni.Length < 9)
                {
                    return true;

                }
            }
            return false;
        }

        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public string Dni
        {
            get
            {
                if (ValidarDni(this.dni))
                {
                    return this.dni;

                }
                else
                {
                    throw new DniInvalidoException("DNI INVALIDO");

                }
            }
            set
            {
                if (ValidarDni(value))
                {
                    this.dni = value;
                }
                else
                {
                    throw new DniInvalidoException("DNI INVALIDO");
                }
            }
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public EMedioDePago MedioDePago
        {
            get { return this.medioDePago; }
            set { this.medioDePago = value; }
        }

        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public string Nombre
        {
            get
            {
                if (ValidarNombre(this.nombre))
                {
                    return this.nombre;

                }
                else
                {
                    throw new NombreInvalidoException("No es un nombre valido");
                }
                
            }
            set
            {
                if (ValidarNombre(value))
                {
                    this.nombre = value;

                }
                else
                {
                    throw new NombreInvalidoException("No es un nombre valido");
                }
            }
        }

        /// <summary>
        /// propiedad de lectura y escritura
        /// </summary>
        public List<Cliente> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }
        #endregion
    }
}
