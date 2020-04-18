using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfinApp.Filmothèque
{
    public class Data
    
    {
        public static SqlConnection openBDD()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source= (localBD)\\MSSQLLocalBD; Initial Catalog=FILMOTHEQUE;";
            try
            {
                //Conexion à la base de donnée
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
                return conn;
            }
            catch (Exception eMsg1)
            {
                Console.WriteLine("Erreur durant l'execution de la requete: " + eMsg1.Message);
                return null;
            }

        }
        

    }
}
