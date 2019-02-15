using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Etudiants
{
    public class Etudiant
    {
        int id;
        string nom;
        string prenom;

        public Etudiant(int id, string nom, string prenom)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public override string ToString()
        {
            return id + "  " + nom + "  " + prenom;
        }
    }


}
