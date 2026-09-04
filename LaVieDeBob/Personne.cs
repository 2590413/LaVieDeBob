using System;
using System.Collections.Generic;
using System.Text;

namespace LaVieDeBob
{
    public class Personne
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public Emploi Emploi { get;}
        public Compte Compte { get;}


        public Personne(string prenom, string nom, string titreEmploi, decimal salaire)
        {
            Nom = Nom;
            Prenom = Prenom;
            Emploi = new (titreEmploi, salaire);
            Compte = new Compte();
        }

        public Personne(string prenom) : this(prenom, "", "Sans emploi", 0)
        { }

        public decimal Travailler(int heures)
        {
            if (heures < 0)
                throw new ArgumentOutOfRangeException("Le nombre d'heures travaillées doit être positif.")

            decimal salaireGagne = heures * Emploi.salaire;
            Compte.Deposer(salaireGagne);

            return salaireGagne;
        }

        public decimal Nourrir(DateTime heureRepas)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Salut! Je m'appelle {Prenom} {Nom}. " +
                   $"Je suis {Emploi.titre} et je gagne " +
                   $"{Emploi.salaire:C}/h";
        }
    }
}
