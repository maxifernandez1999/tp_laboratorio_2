using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using static ClasesInstanciables.Universidad;
namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta { AlDia,Deudor,Becado}
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor publico sin parametros
        /// </summary>
        public Alumno()
        {
                
        }

        /// <summary>
        /// Constructor publico parametrizado
        /// </summary>
        /// <param name="id">legajo del Alumno</param>
        /// <param name="nombre">nombre del Alumno</param>
        /// <param name="apellido">apellido del Alumno</param>
        /// <param name="dni">dni del Alumno</param>
        /// <param name="nacionalidad">nacionalidad del Alumno</param>
        /// <param name="claseQueToma">clase que toma el Alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {

        }
        /// <summary>
        /// Constructor publico parametrizado
        /// </summary>
        /// <param name="id">legajo del Alumno</param>
        /// <param name="nombre">nombre del Alumno</param>
        /// <param name="apellido">apellido del Alumno</param>
        /// <param name="dni">dni del Alumno</param>
        /// <param name="nacionalidad">nacionalidad del Alumno</param>
        /// <param name="claseQueToma">clase que toma el Alumno</param>
        /// <param name="estadoCuenta">estado de la cuenta del Alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma,EEstadoCuenta estadoCuenta) 
            :this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }
        #endregion


        #region METODOS

        /// <summary>
        /// Muestra los datos del alumno
        /// </summary>
        /// <returns>Retorna los datos completos de un alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLET0: {base.Apellido}, {base.Nombre}");

            sb.AppendLine($"{base.MostrarDatos()}");
            if (this.estadoCuenta == Alumno.EEstadoCuenta.AlDia)
            {
                sb.AppendLine($"ESTADO DE CUENTA : Cuota al dia");
            }
            else
            {
                sb.AppendLine($"ESTADO DE CUENTA : {this.estadoCuenta}");
            }
            
            sb.AppendLine($"{this.ParticipaEnClase()}");
            

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del metodo abstracto de la base
        /// </summary>
        /// <returns>Retorna un string con la clase que toma el alumno</returns>
        protected override string ParticipaEnClase()
        {
            return "TOMA CLASE DE: " + this.claseQueToma;
        }

        /// <summary>
        /// Muestra los datos del alumno
        /// Reutiliza el metodo MostrarDatos()
        /// </summary>
        /// <returns>Retorna los datos del alumno</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// Son iguales un alumno y una clase, si toma esa clase y no es deudor
        /// </summary>
        /// <param name="a">alumno</param>
        /// <param name="clase">clase</param>
        /// <returns>retorna true si se valido, false si no se pudo</returns>
        public static bool operator ==(Alumno a, EClases clase)
        {
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Son distintos un alumno y una clase, si este no cursa la clase
        /// </summary>
        /// <param name="a">alumno</param>
        /// <param name="clase">clase</param>
        /// <returns>retorna true si se valido, false si no se pudo</returns>
        public static bool operator !=(Alumno a, EClases clase)
        {
            if (a.claseQueToma != clase)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
