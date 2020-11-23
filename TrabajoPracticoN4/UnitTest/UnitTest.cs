using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Excepciones;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
namespace UnitTest
{

    [TestClass]
    public class UnitTest
    {

        /// <summary>
        /// metodo que verifica que se lanze una excepcion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PlataformaInvalidaException))]
        public void ProbarInstanciaDeClases()
        {
            Games games = new Games(2100, 2008, "Uncharted 2", 83, Games.EFormato.Fisico, "PS8");

        }

        /// <summary>
        /// metodo que verifica que traiga todos los datos de la Base de Datos de la tabla Games
        /// </summary>
        [TestMethod]
        public void ProbarDatosTraidosDeBaseDeDatosGames()
        {
            GamesDAO gamesDAO = new GamesDAO();
            List<Games> games = gamesDAO.List();
            Assert.IsTrue(games.Count == 63); //63 SON LOS ELEMENTOS TOTOLES DE LA BASE DE DATOS

        }

        /// <summary>
        /// metodo que verifica que traiga todos los datos de la Base de Datos de la tabla Games
        /// </summary>
        [TestMethod]
        public void ProbarDatosTraidosDeBaseDeDatosPS()
        {
            ConsolasDAO consolasDAO = new ConsolasDAO();
            List<PS> ps = consolasDAO.List();
            Assert.IsTrue(ps.Count == 9); // ELEMENTO TOTALES DE LA BASE DE DATOS

        }


        /// <summary>
        /// metodo que verifica que la lista no sea null
        /// </summary>
        [TestMethod]
        public void ProbarInstanciaDeListasGames()
        {
            Games games = new Games();
            Assert.IsNotNull(games.ListaJuegos);

        }


        /// <summary>
        /// metodo que verifica que la lista no sea null
        /// </summary>
        [TestMethod]
        public void ProbarInstanciaDeListasPS()
        {
            PS ps = new PS();
            Assert.IsNotNull(ps.ListaJuegosPSVenta);

        }


        /// <summary>
        /// metodo que verifica que la lista no sea null
        /// </summary>
        [TestMethod]
        public void ProbarInstanciaDeListasCliente()
        {
            Cliente cliente = new Cliente();
            Assert.IsNotNull(cliente.Clientes);

        }





    }
}
