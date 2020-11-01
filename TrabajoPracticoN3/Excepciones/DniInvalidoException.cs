﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException() :base("El DNI tiene que ser numerico y el maximo debe ser 99999999.")
        {
        }
        public DniInvalidoException(Exception e) : base()
        {

        }
        public DniInvalidoException(string message) : base(message)
        {

        }
        public DniInvalidoException(string message, Exception e) : base(message,e)
        {

        }
    }
}
