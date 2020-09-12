using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    { 
        private double numero;

        /// <summary>
        /// Constructor por defecto que inicializa el atributo numero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor parametrizado que inicializa el atributo con double numero
        /// </summary>
        /// <param name="numero">numero a guardar en el atributo de la clase</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor parametrizado que inicializa el atributo
        /// </summary>
        /// <param name="strNumero">cadena a guardar en el atributo</param>
        public Numero(string strNumero)
        {

            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Propiedad que valida que el valor sea un numerico y lo guarda en el atributo numero
        /// </summary>
        public string SetNumero
        { 
            set
            {
                double num;
                num = (ValidarNumero(value));
                if(num != 0)
                {
                    this.numero = num;
                }
                
            }
        }
        /// <summary>
        /// Valida si el valor del parametro es un valor numerico
        /// </summary>
        /// <param name="strNumero">cadena a validar</param>
        /// <returns> retorna el numero parseado a double o (0)</returns>
        public double ValidarNumero(string strNumero)
        {
            double retorno;
            double numero;
            if(double.TryParse(strNumero, out numero))
            {
                retorno = numero;
            }
            else
            {
                retorno = 0;
            }
            return retorno;
        }
        /// <summary>
        /// Valida si el valor del parametro esta compuesto por 0 o 1(binario)
        /// </summary>
        /// <param name="binario">cadena a validar</param>
        /// <returns>retorna true; si el valor es binario y false; si no lo es</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;
            foreach(var caracter in binario)
            {
                if(caracter == '0' || caracter == '1')
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte el valor del parametro a un numero binario
        /// </summary>
        /// <param name="numero">Numero a parsear</param>
        /// <returns>retorna una cadena con el numero binario ya parseado</returns>
        public string DecimalBinario(double numero)
        {
            int num1 = (int)numero;
            string binario;
            if(num1 > 0)
            {
                binario = Convert.ToString(num1, 2);
            }
            else
            {
                binario = "Error";
            }
            return binario;
        }

        /// <summary>
        /// Convierte el valor del parametro a un numero binario
        /// </summary>
        /// <param name="numero">Cadena a parsear</param>
        /// <returns>retorna una cadena con el numero binario ya parseado</returns>
        public string DecimalBinario(string numero)
        {
            int numero1;
            double num1;
            string binario;
            string retorno = "";
            if (double.TryParse(numero, out num1))
            {
                numero1 = (int)num1;
                if (numero1 > 0)
                {
                    binario = Convert.ToString(numero1, 2);
                    retorno = binario;
                }
                else
                {
                    retorno = "Valor Invalido";
                }

            }
            return retorno;
        }

        /// <summary>
        /// Convierte el valor del parametro en valor decimal
        /// </summary> 
        /// <param name="binario">cadena a convertir</param>
        /// <returns>retorna el valor decimal ya convertido</returns>
        public string BinarioDecimal(string binario)
        {
            double entero;
            string cadena;
            string msj;
            if (EsBinario(binario) == true)
            {
                entero = Convert.ToInt32(binario, 2);
                cadena = Convert.ToString(entero);
                msj = cadena;
            }
            else
            {
                msj = "Valor Invalido.";
                
            }
            return msj;
            
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="num1">valor del tipo Numero</param> 
        /// <param name="num2">valor del tipo Numero</param>
        /// <returns>retorna un double con la operacion entre ambos numeros</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="num1">valor del tipo Numero</param> 
        /// <param name="num2">valor del tipo Numero</param>
        /// <returns>retorna un double con la operacion entre ambos numeros</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador *
        /// </summary>
        /// <param name="num1">valor del tipo Numero</param> 
        /// <param name="num2">valor del tipo Numero</param>
        /// <returns>retorna un double con la operacion entre ambos numeros</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador / . Valida que el num2 no sea igual a 0
        /// </summary>
        /// <param name="num1">valor del tipo Numero</param> 
        /// <param name="num2">valor del tipo Numero</param>
        /// <returns>retorna un double con la operacion entre ambos numeros o el double.MinValue</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            double retorno;
            if (num2.numero != 0)
            {
                retorno = num1.numero / num2.numero;
            }
            else
            {
                retorno = double.MinValue;
            }
            return retorno;
        }
       
    }
}
