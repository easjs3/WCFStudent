using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClient
{
    class Program
    {

        //metode til at få fat i connectionString i Appconfig
        private static string GetConnectionString()
        {
            ConnectionStringSettingsCollection connectionStringSettingsCollection = ConfigurationManager.ConnectionStrings;
            ConnectionStringSettings connStringSettings = connectionStringSettingsCollection["MikDatabaseAzure"];
            return connStringSettings.ConnectionString;
        }

        static void Main(string[] args)
        {
            //vi øsnker at lave quary som hvis vi selv bruger den
            string GetAll = "select * from Student";

            //vores string til databasen
            string DatabaseLinje = GetConnectionString();
            //man finder den ved at gå ind på:
            ///1. går ind på azure
            /// 2. tryk på din sql
            /// 3. connection strings og brug ADO.NET
    

            

            using (SqlConnection DBconnection = new SqlConnection(DatabaseLinje))
            {
                DBconnection.Open();
                using (SqlCommand SelectCommand = new SqlCommand(GetAll, DBconnection))
                {
                    using (SqlDataReader reader = SelectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int alder = reader.GetInt32(0);
                            string navn = reader.GetString(1);
                            Console.WriteLine($"ID:{alder} Navn: {navn}");
                        }
                    }
                }
            }
            Console.ReadLine();


        }
    }
}
