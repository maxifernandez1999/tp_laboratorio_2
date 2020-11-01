using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero}
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #region CONSTRUCTORES

        /// <summary>
        /// Constructor publico sin parametros
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor publico parametrizado
        /// </summary>
        /// <param name="nombre">nombre de la persona</param>
        /// <param name="apellido">apellido de la persona</param>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor publico parametrizado
        /// </summary>
        /// <param name="nombre">nombre de la persona</param>
        /// <param name="apellido">apellido de la persona</param>
        /// /// <param name="dni">dni de la persona representado en dato numerico</param>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        { 
            this.DNI = dni;  
        }

        /// <summary>
        /// Constructor publico parametrizado
        /// </summary>
        /// <param name="nombre">nombre de la persona</param>
        /// <param name="apellido">apellido de la persona</param>
        /// /// <param name="dni">dni de la persona representado en cadena de texto</param>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Sobrecarga del metodo ToString()
        /// </summary>
        /// <returns>Retorna todos los datos de una persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nacionalidad : {this.Nacionalidad}");
            sb.AppendLine($"Nombre : {this.Nombre}");
            sb.AppendLine($"Apellido : {this.Apellido}");
            sb.AppendLine($"DNI : {this.StringToDNI}");
            
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que valido el dni segun la nacionalidad de la persona
        /// </summary>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        /// <param name="dato">dni de la persona representado en valor numerico</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            string datoString = dato.ToString();
            int datoValidado;
            bool retorno = int.TryParse(datoString, out datoValidado);
            if (retorno == true && datoString.Length > 7)
            {
                if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999)
                {
                    return dato;
                }
                else if (nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
                {
                    return dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else
            {
                throw new DniInvalidoException();
            }

        }

        /// <summary>
        /// Metodo que valido el dni segun la nacionalidad de la persona
        /// </summary>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        /// <param name="dato">dni de la persona representado en texto</param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int datoValidado;
            bool retorno = int.TryParse(dato, out datoValidado);
            if (retorno == true && dato.Length > 7)
            {
                if (nacionalidad == ENacionalidad.Argentino && datoValidado >= 1 && datoValidado <= 89999999)
                {
                    return datoValidado;
                }
                else if (nacionalidad == ENacionalidad.Extranjero && datoValidado >= 90000000 && datoValidado <= 99999999)
                {
                    return datoValidado;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else
            {
                throw new DniInvalidoException();
            }
        }

        /// <summary>
        /// Valida que el nombre y el apellido 
        /// esten conformados unicamente por letras
        /// </summary>
        /// <param name="dato">nombre o apellido</param>
        /// <returns>returna el dato valido o "false" si no se pudo</returns>
        private string ValidarNombreApellido(string dato)
        {
            bool retorno = false;
            foreach (char caracter in dato)
            {
                if (char.IsLetter(caracter))
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            if (retorno == true)
            {
                return dato;
            }
            return "false";
        }
        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura y escritura
        /// Utiliza las validaciones para luego inicializar el apellido con los datos
        /// </summary>
        public string Apellido
        {
            get
            {
                string getApellidoValido = ValidarNombreApellido(this.apellido);
                if (getApellidoValido == "false")
                {
                    return this.apellido = "";
                }
                return getApellidoValido;
            }
            set
            {
                string setApellidoValido = ValidarNombreApellido(value);
                if (setApellidoValido == "false")
                {
                    this.apellido = "";
                }
                this.apellido = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// Inicializa el atributo nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// Utiliza las validaciones para luego inicializar el DNI con los datos
        /// </summary>
        public int DNI
        {
            get
            {
                int datoValidado = ValidarDni(this.nacionalidad, this.dni);
                return datoValidado;
            }
            set
            {
                int datoValidado = ValidarDni(this.nacionalidad, value);
                this.dni = datoValidado;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura
        /// Utiliza las validaciones para luego inicializar el nombre con los datos
        /// </summary>
        public string Nombre
        {
            get
            {
                string getNombreValido = ValidarNombreApellido(this.nombre);
                if (getNombreValido == "false")
                {
                    return this.apellido = "";
                }
                return getNombreValido;
            }
            set
            {
                string setNombreValido = ValidarNombreApellido(value);
                if (setNombreValido == "false")
                {
                    this.nombre = "";
                }
                this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura
        /// Utiliza las validacion para luego inicializar el DNI tipo string con los datos
        /// </summary>
        public string StringToDNI
        {
            get
            {
                string valorValidado = Convert.ToString(this.dni);
                int datoValidado = ValidarDni(nacionalidad, valorValidado);
                return datoValidado.ToString();
            }
            set
            {
                int datoValidado = ValidarDni(this.nacionalidad, value);
                this.dni = datoValidado;
            }
        }
        #endregion
    }
}
