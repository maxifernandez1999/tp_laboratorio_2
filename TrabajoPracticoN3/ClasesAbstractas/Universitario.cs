using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor publico sin parametros
        /// </summary>
        public Universitario()
        {

        }
        /// <summary>
        /// Constructor publico parametrizado
        /// </summary>
        /// <param name="legajo">atributo legajo</param>
        /// <param name="nombre">atributo de la clase base</param>
        /// <param name="apellido">atributo de la clase base</param>
        /// <param name="dni">atributo de la clase base</param>
        /// <param name="nacionalidad">atributo de la clase base</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Metodo virtual y protegido
        /// </summary>
        /// <returns>Retorna todos los datos de la clase base mas los de la clase</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NACIONALIDAD: {base.Nacionalidad}");

            sb.AppendLine($"LEGAJO NUMERO : {this.legajo}");
            //sb.AppendLine($"{base.ToString()}");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo abstracto
        /// </summary>
        /// <returns>Retorna una cadena de texto</returns>
        protected abstract string ParticipaEnClase();


        /// <summary>
        /// Compara si dos instancias son iguales
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Universitario)
            {
                retorno = this == (Universitario)obj;
            }
            return retorno;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// Dos objetos de tipo Universitorio son iguales si coinciden en su instancia 
        /// , y su dni o legajo son iguales
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>Retorna true si se valido, false si no se pudo validar</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.GetType() == pg2.GetType() && (pg1.StringToDNI == pg2.StringToDNI) || (pg1.legajo == pg2.legajo) && (pg1.legajo != 0 && pg2.legajo != 0))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Dos objetos de tipo Universitorio son distintos si no coinciden en su instancia 
        /// , y su dni o legajo son distintos
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>Retorna true si se valido, false si no se pudo validar</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
