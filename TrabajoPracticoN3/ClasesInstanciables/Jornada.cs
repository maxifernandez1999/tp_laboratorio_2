using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;
using Archivos;
namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;


        #region CONSTRUCTORES

        /// <summary>
        /// Constructor private que instancia la lista de alumnos
        /// </summary>
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor que inicializa los datos de la Jornada
        /// </summary>
        /// <param name="clase">clase</param>
        /// <param name="instructor">Profesor</param>
        public Jornada(EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura y escritura de la lista de Alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de la clase
        /// </summary>
        public EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del profesor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Guarda los datos de la jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada">jornada</param>
        /// <returns>retorno true si pudo, false si no pudo</returns>
        public static bool Guardar(Jornada jornada) // Archivo de texto
        {
            Texto texto = new Texto();
            return texto.Guardar("Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Lee los datos de la jornada en un archivo de texto
        /// </summary>
        /// <returns>retorno true si pudo, false si no pudo</returns>
        public static bool Leer()//Archivo de texto
        {
            Texto texto = new Texto();
            string datos;
            bool valor = texto.Leer("Jornada.txt", out datos);
            if (valor == true)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASE DE {this.Clase} POR NOMBRE COMPLETO: {this.Instructor.Apellido}, {this.Instructor.Nombre}");
            sb.AppendLine($"{this.Instructor.ToString()}");

            sb.AppendLine($"ALUMNOS: ");

            foreach (Alumno a in this.Alumnos)
            {
                sb.AppendLine($"{a.ToString()}");
            }

            return sb.ToString();

        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Una jornada y un alumno son iguales, si el alumno pertenece a la lista de alumnos de la jornada
        /// </summary>
        /// <param name="i">Jornada</param>
        /// <param name="clase">Alumno</param>
        /// <returns>True valido ok, false no pertenece a la lista</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno alumno in j.Alumnos)
            {
                if (a == alumno)
                {
                    retorno = true;
                    break;
                }
                retorno = false;

            }
            return retorno;
        }

        /// <summary>
        /// Una jornada y un alumno son distintos, si el alumno no pertenece a la lista de alumnos de la jornada
        /// </summary>
        /// <param name="i">Jornada</param>
        /// <param name="clase">Alumno</param>
        /// <returns>True valido ok, false pertenece a la lista</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega un alumno a lista, si ya no esta agregado previamente
        /// </summary>
        /// <param name="j">Jornada</param>
        /// <param name="a">Alumno</param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
                return j;
            }
            return j;
        }
        #endregion
    }
}
