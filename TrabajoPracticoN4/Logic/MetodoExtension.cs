using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class MetodoExtension
    {

        /// <summary>
        /// Obtiene el precio total de los productos agregados al carrito
        /// </summary>
        /// <returns>Retorna el valor total de los productos</returns>
        public static int ObtenerPrecioJuegos(this int preciototal, Games game)
        {
            int total = 0;
            if (game.ListaJuegos.Count == 0)
            {
                return total;
            }
            foreach (Games g in game.ListaJuegos)
            {
                int precio = g.Precio;
                total = total + precio;

            }
            return total;
        }


        /// <summary>
        /// Obtiene el precio total de las consolas agregadas al carrito
        /// </summary>
        /// <returns>retorna el precio total</returns>
        public static int ObtenerPrecioTotalConsolas(this int preciototal, PS ps)
        {
            int total = 0;
            foreach (PS g in ps.ListaJuegosPSVenta)
            {
                int precio = g.Precio;
                total = total + precio;

            }
            return total;
        }
    }
}
