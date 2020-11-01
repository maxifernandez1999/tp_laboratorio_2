using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
namespace ClasesInstanciables
{
    public class Universidad
    {

        //        Clase Universidad:
        //• Atributos Alumnos(lista de inscriptos), Profesores(lista de quienes pueden dar clases) y Jornadas.
        //• Se accederá a una Jornada específica a través de un indexador.

        //• Si al querer agregar alumnos este ya figura en la lista, lanzar la excepción AlumnoRepetidoException.
        //• MostrarDatos será privado y de clase. Los datos del Universidad se harán públicos mediante
        //ToString.
        //• Guardar de clase serializará los datos del Universidad en un XML, incluyendo todos los datos de sus
        //Profesores, Alumnos y Jornadas.
        //• Leer de clase retornará un Universidad con todos los datos previamente serializados.

        //        MostrarDatos será privado y de clase.Los datos del Universidad se harán públicos mediante
        //ToString.

        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #region CONSTRUCTORES

        /// <summary>
        /// Constructor publico sin parametros
        /// Se encarga de instanciar las listas
        /// </summary>
        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }

        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura y escritura de Alumnos
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
        /// Propiedad de lectura y escritura de Jornada
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de Profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// Indexador de Jornada
        /// </summary>
        /// <param name="i">Indice</param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Guarda el contenido de Unirsidad en un Archivo Xml
        /// </summary>
        /// <param name="uni">Universidad</param>
        /// <returns>Retorno true si pudo guardar, false si no pudo</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            if (xml.Guardar("Universidad.xml", uni))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Lee un archivo Xml
        /// </summary>
        /// <returns>Retorno una Universidad si pudo leerlo</returns>
        public Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad uni;
            bool retorno = xml.Leer("Universidad.xml",out uni);
            if (retorno == true)
            {
                return uni;
            }
            return uni;
        }

        /// <summary>
        /// Muestra los datos de la universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"JORNADA");
            foreach (Jornada j in uni.Jornadas)
            {
                sb.AppendLine($"{j.ToString()}");
                sb.AppendLine($"<---------------------------------------------------->");

            }

            return sb.ToString();
        }


        /// <summary>
        /// Hace publico el metodo MostrarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        #endregion

        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// Una Universidad y un Alumno son iguales si esta inscripto en la Universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>True si encontro un Alumno, false si no pudo</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno alumno in g.Alumnos)
            {
                if (a == alumno)
                {
                    retorno = true;
                    break;
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
        /// Una Universidad y un Profesor son iguales si da clases en la Universidad
        /// </summary>
        /// <param name="g">Universidad</param>
        /// <param name="a">Profesor</param>
        /// <returns>True si encontro un profesor, false si no pudo</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.Instructores)
            {
                if (i == profesor)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Busca el primer profesor capaz de dar la clase 
        /// </summary>
        /// <param name="u">Universidad</param>
        /// <param name="clase">clase</param>
        /// <returns>Retorna el primer profesor que puede dar la clase, sino lanza una excepcion</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor prof = null;
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                {
                    prof = profesor;
                    return prof;
                }
            }
            throw new SinProfesorException();
            
        }

        /// <summary>
        /// Una Universidad y un Alumno son distintos si no esta inscripto en la Universidad
        /// </summary>
        /// <param name="g">Universidad</param>
        /// <param name="a">Alumno</param>
        /// <returns>true si es distinto, false si es igual</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Una Universidad y un Profesor son distintos si no da clases en la Universidad
        /// </summary>
        /// <param name="g">Universidad</param>
        /// <param name="a">Profesor</param>
        /// <returns>true si es distinto, false si es igual</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Busca el primer profesor que no puede dar la clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>Retorno el primer profesor que no puede dar la clase</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor prof = null;
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor != clase)
                {
                    prof = profesor;
                    break;
                }
            }
            if (prof != null)
            {
                return prof;
            }
            return prof;
        }

        /// <summary>
        /// Agrega un Alumno a a la Universidad si este no esta previamente cargado
        /// </summary>
        /// <param name="u">Universidad</param>
        /// <param name="a">Alumno</param>
        /// <returns>Retorno un alumno si no es cargado, sino lanza una excepcion</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            
        }

        /// <summary>
        /// Agrega un Alumno a a la Universidad si este no esta previamente cargado
        /// </summary>
        /// <param name="u">Universidad</param>
        /// <param name="a">Alumno</param>
        /// <returns>Retorno un alumno si no es cargado</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
                return u;
            }
            return u;
        }


        /// <summary>
        /// Genera y agrega una nueva jornada, con la clase y el profesor que puede darla,
        /// y agrega los alumnos que pueden dar dicha clase
        /// </summary>
        /// <param name="g">Universidad</param>
        /// <param name="clase">Clase</param>
        /// <returns>Retorno variable de tipo Univesidad</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profDisponible = g == clase;
            Jornada jor = new Jornada(clase, profDisponible);
            g.Jornadas.Add(jor);
            foreach (Alumno a in g.Alumnos)
            {
                if (a == clase)
                {
                    jor.Alumnos.Add(a);
                }
            }
            return g;
        }
        #endregion


    }
}
