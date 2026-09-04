using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;





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