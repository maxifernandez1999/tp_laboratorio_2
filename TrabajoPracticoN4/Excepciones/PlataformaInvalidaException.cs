using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PlataformaInvalidaException : Exception
    {

        public PlataformaInvalidaException()
        {

        }
        public PlataformaInvalidaException(string message) : base(message)
        {

        }
        public PlataformaInvalidaException(string message,Exception innerException) : base(message, innerException)
        {

        }
    }
}
