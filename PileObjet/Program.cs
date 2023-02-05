using System;
using Utilitaires;
using PileObjet.Tests;


namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPile.TestePileVide();
            TestPile.TesteEmpiler();
            TestPile.TesteEmpilerDepiler();
            TestPile.TesteConversion();
            TestPile.TesteConversion(154, 2);
            TestPile.TesteConversion(11, 16);
            TestPile.TesteConversion(2986, 16);
            TestPile.TesteConversion(9999, 16);
            TestPile.TesteInversePhrase();
            Console.WriteLine(Utilitaire.InversePhrase("J'ai bientôt fini le tp"));
            Console.WriteLine("Fin du progamme");
            Console.ReadKey();
        }
    }
}
