using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// interface generica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IBaseDatos<T>
    {
        List<T> List();
    }
}
