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
    public class ConsolasDAO : IBaseDatos<PS>
    {
        private SqlConnection sqlConnection;
        private string connectionString;

        /// <summary>
        /// constructor que establece la conexion a la base de datos
        /// </summary>
        public ConsolasDAO()
        {
            this.connectionString = "Server=.\\SQLEXPRESS;Database=GamesDB;Trusted_Connection=True;"; //direccion para la conexion a BD
            this.sqlConnection = new SqlConnection(connectionString);

        }

        /// <summary>
        /// metodo que genera una lista de consolas extraida de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<PS> List()
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Consolas";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<PS> Consolas = new List<PS>();

                while (reader.Read())
                {
                    int codigo = (int)reader["codigo"];
                    string modelo = (string)reader["modelo"];
                    int precio = (int)reader["precio"];
                    int lanzamiento = (int)reader["lanzamiento"];
                    int almacenamiento = (int)reader["almacenamiento"];
                    PS Cons = new PS(precio, almacenamiento, modelo, codigo, lanzamiento);
                    Consolas.Add(Cons);
                }
                return Consolas;
            }
        }
        

    }
}
