using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos.ClasesDAT
{
    public class ConexionBD
    {
        public MySqlConnection conx;
        private string server;
        private string database;
        private string uid;
        private string password;


        public ConexionBD()
        {
            server = "qzl800.guancheweb.com";
            database = "qzl800";
            uid = "qzl800";
            password = "Piensa609";

            string connString = $"SERVER ={server};DATABASE={database};UID={uid};PASSWORD={password};";
            conx = new MySqlConnection(connString);

        }
    }
}
