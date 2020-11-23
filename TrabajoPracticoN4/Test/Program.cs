using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Excepciones;
namespace Test
{
    class Program
    {
        //PROGRAMA DE CONSOLA PARA PROBAR FUNCIONALIDADES
        static void Main(string[] args)
        {
            GamesDAO gamesDAO = new GamesDAO(); //CREO INSTANCIA DE CLASE ENCARGADA DE CONECTAR CON LA BD
            ConsolasDAO consolasDAO = new ConsolasDAO();
            Games juegos = new Games();
            PS ps = new PS();
            List<Games> listGames = gamesDAO.List(); //OBTENGO UNA LISTA DE JUEGOS DE LA BD
            List<PS> listPs = consolasDAO.List(); //OBETENGO UNA LISTA DE CONSOLA DE LA BD
            juegos.CargarStock(); // CARGA DATOS DE LA TABLA DE JUEGOS
            ps.CargarStockPS(); //CARGA DATOS DE LA TABLA DE CONSOLAS

            //EJEMPLO DE CARGA DE DATOS POR MODELO
            List<PS> PS1 = new List<PS>(); 
            PS1 = ps.StockConsolaPS1(ps);
            Console.WriteLine(PS.MostrarDatosPS(PS1));
            Console.WriteLine("Juegos agregados correctamente");
            //VENTA DE JUEGO
            try
            {
                Games venta = new Games(2100, 2008, "Uncharted 3", 83, Games.EFormato.Fisico, "PS5"); //DATOS INVALIDOS PARA PROBAR EXCEPCIONES
                
            }
            catch (PlataformaInvalidaException ex)
            {
                Console.WriteLine("Exception Games " + ex.Message);
            }

            //VENTA DE CONSOLA

            PS ventaps = new PS(10000, 500, "PS1", 1, 2013);

            //CARGA DE CLIENTES

            try
            {
                Cliente cli = new Cliente("45Elpepe", "42568956", EMedioDePago.efectivo, 12000);
                
            }
            catch (NombreInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                Cliente cliente = new Cliente("Elpepe", "425615sadf", EMedioDePago.efectivo, 12000);

            }
            
            catch (DniInvalidoException ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("DESERIALIZACION\n");

            ///PRUEBA DE SERIALIZACION
            ArchivosXml<List<Games>> xml = new ArchivosXml<List<Games>>();
            xml.Guardar("ArchivoXmlGamesPrueba.txt", listGames);
            List<Games> datos;
            xml.Leer("ArchivoXmlGamesPrueba.txt",out datos);
            Console.WriteLine(Games.MostrarDatos(datos));

            //PRUEBA DE ARCHIVO DE TEXTO

            ArchivoTexto t = new ArchivoTexto();
            t.GuardarArchivoTexto("ArchivoTexTest.txt", Games.MostrarDatos(datos), false);

            //

            Console.ReadKey();
        }
    }
}
