using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
namespace Gestion_Etudiants
{
    class Connexion
    {
        public static MySqlConnection cnx = null;
        private Connexion(string bd,string serv,string user,string pass)
        {
            cnx = new MySqlConnection("database=" + bd + "; server=" + serv + "; uid=" + user + "; password=" + pass);
            cnx.Open();
        }

        public static MySqlConnection MySqlConnect(string bd, string serv = "localhost", string user = "root", string pass = "")
        {z
            if (cnx == null)
                new Connexion(bd, serv, user, pass);

            return cnx;
        }

        public static void MySqlDeconnect()
        {
            if (cnx != null)
            { 
                cnx.Close();
                cnx = null;
            }
        }
        
    }
}
