using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza las operaciones +,-,*,/ con previa validacion del operador
        /// </summary>
        /// <param name="num1">variable del tipo Numero a operar</param>
        /// <param name="num2">variable del tipo Numero a operar</param>
        /// <param name="operador">string del operador</param>
        /// <returns>retorna un valor de tipo double con el resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            char operador1 = Convert.ToChar(operador);
            switch (ValidarOperador(operador1))
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    
                    break;

                default:
                    break;
            }
            return retorno;


        }

        /// <summary>
        /// Valida si el operador ingresado es +, -, *, o /
        /// </summary>
        /// <param name="operador">operador a validar</param>
        /// <returns>retorna el operador ya validado. En caso contrario devuelve +</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno;
            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = char.ToString(operador);
            }
            else
            {
                retorno = "+";
            }
            return retorno;
        }
    }
}
