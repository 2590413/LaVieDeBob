using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Personne
{
    public string Nom { get;}
    public string Prenom { get;}
    public Emploi emploi { get; set; }
    public Compte compte { get; set; }

    public Personne()
    {
        Nom = "";
        Prenom = "";
        Emploi emploi = new Emploi();
        Compte compte = new Compte();
    }

    public Personne(string Nom, string Prenom, Emploi emploi, Compte compte)
    {
        Nom = Nom;
        Prenom = Prenom;
        emploi = emploi;
        compte = compte;
    }
}

public class Emploi
{
    public string Titre { get; }
    public decimal Salaire { get; }

    public Emploi()
    {
        Titre = "";
        Salaire = 0;
    }

    public Emploi(string Titre, decimal Salaire)
    {
        Titre = Titre;
        Salaire = Salaire;
    }
}

public class Compte
{
    public decimal Solde { get; }
   
    public Compte()
    {
        Solde = 0;
    }

    public Compte(decimal Solde)
    {
        Solde = Solde;
    }
}