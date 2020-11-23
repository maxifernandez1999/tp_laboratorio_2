using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Logic;
using System.Threading;

namespace Logic
{
    public class GamesDAO : IBaseDatos<Games>
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        /// <summary>
        /// constructor que establece la conexion a la base de datos
        /// </summary>
        public GamesDAO()
        {
            this.connectionString = "Server=.\\SQLEXPRESS;Database=GamesDB;Trusted_Connection=True;"; //direccion para la conexion a BD
            this.sqlConnection = new SqlConnection(connectionString);

        }

        /// <summary>
        /// metodo que obtiene una lista de juegos extraida de la base de datos
        /// </summary>
        /// <returns>lista de juegos</returns>
        public List<Games> List()
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Games";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Games> psList = new List<Games>();

                while (reader.Read())
                {
                    int codigo = (int)reader["codigo"];
                    string nombre = (string)reader["nombre"];
                    int precio = (int)reader["precio"];
                    int lanzamiento = (int)reader["lanzamiento"];
                    string formato = (string)reader["formato"];
                    string plataforma = (string)reader["plataforma"];
                    Games.EFormato formatoEnum = (Games.EFormato)Enum.Parse(typeof(Games.EFormato), formato);
                    Games gamesPS = new Games(precio, lanzamiento, nombre, codigo,formatoEnum,plataforma,"NO");
                    psList.Add(gamesPS);
                }
                return psList;
            }
        }
        

    }
}
