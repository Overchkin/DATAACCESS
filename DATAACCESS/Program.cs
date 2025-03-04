using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DATAACCESS
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection
                ("Server=localhost,1433;Database=ApprendreCsharp;User Id=sa;Password=Passw0rd*; " +
                "TrustServerCertificate=True");

            connection.Open();
            try
            {
                Console.WriteLine("Connexion ouverte !");
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Personnes(Nom, Prenom) VALUES('SNOW', 'John')";
                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    System.Console.WriteLine("Insertion effectuée avec succès");
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
