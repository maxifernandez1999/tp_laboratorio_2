using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using static ClasesInstanciables.Universidad;
using System.Threading;
namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<EClases> claseDelDia;
        private static Random random;

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor privado que instancia a Queue y la clase del dia
        /// </summary>
        public Profesor() :this(default,default,default,default,default)
        {
            
        }
        /// <summary>
        /// Constructor que instancia el Random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor publico parametrizado que inicializa los atributos de Profesor
        /// </summary>
        /// <param name="id">id de profesor</param>
        /// <param name="nombre">nombre profesor</param>
        /// <param name="apellido">apellido profesor</param>
        /// <param name="dni">dni profesor</param>
        /// <param name="nacionalidad">nacionalidad profesor</param>
        public Profesor(int id, string nombre, string apellido, string dni,ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseDelDia = new Queue<EClases>();
            _randomClases();
            Thread.Sleep(1000);
            _randomClases();

        }
        #endregion

        #region METODOS

        /// <summary>
        /// Crea un numero random
        /// </summary>
        private void _randomClases()
        {
            this.claseDelDia.Enqueue((EClases)random.Next(0,3));
        }

        /// <summary>
        /// Muestra los datos de Profesor
        /// </summary>
        /// <returns>Retorna una cadena de texto con los datos del profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"CLASES DEL DIA: ");
            foreach (EClases c in this.claseDelDia)
            {
                sb.AppendLine($"{c}");
            }


            return sb.ToString();
        }

        /// <summary>
        /// Indica la clase que toma el Profesor
        /// </summary>
        /// <returns>Retorna cadena de texto con la clase que toma el Profesor</returns>
        protected override string ParticipaEnClase()
        {
            return "TOMA CLASE DE: " + this.claseDelDia;
        }

        /// <summary>
        /// Muestra los datos. Reutiliza MostrarDatos()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// Un profesor y una clase son iguales si este dicta ese clase ese dia
        /// </summary>
        /// <param name="i">Profesor</param>
        /// <param name="clase">clase</param>
        /// <returns>True valido ok, false Profesor no dicta la clase del dia</returns>
        public static bool operator ==(Profesor i, EClases clase)
        {
            bool retorno = false;
            foreach (EClases c in i.claseDelDia)
            {
                //int claseEntero = (int)clase;
                
                if (c == clase)
                {
                    retorno =  true;
                    break;
                }
                retorno = false;
            }
            return retorno;
        }

        /// <summary>
        /// Un profesor y una clase son distintos si este no dicta esa clase ese dia
        /// </summary>
        /// <param name="i">Profesor</param>
        /// <param name="clase">clase</param>
        /// <returns>True valido ok, false Profesor dicta la clase</returns>
        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
