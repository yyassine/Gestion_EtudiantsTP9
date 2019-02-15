using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
namespace Gestion_Etudiants
{
    public class DAOEtudiant
    {
        MySqlConnection MyCon = Connexion.MySqlConnect("ensat");

        public int Ajouter(Etudiant etd)
        {
            string sql = "insert into etudiant(nom,prenom) values('" + etd.Nom + "','" + etd.Prenom + "')";
            Console.WriteLine(sql);
            MySqlCommand cmd = new MySqlCommand(sql, MyCon);
            return cmd.ExecuteNonQuery();
        }

        public List<Etudiant> Lister(int id = 0)
        {
            List<Etudiant> list = new List<Etudiant>();
            string sql = "select * from etudiant ";
            if (id != 0)
                sql += "where id=" + id;

            MySqlCommand cmd = new MySqlCommand(sql, MyCon);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                list.Add(new Etudiant(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString()));
            return list;


        }
    }
}
