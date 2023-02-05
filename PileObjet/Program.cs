using System;
using Utilitaires;
using PileObjet.Tests;

namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestePileVidePleine(5);
            //TestePileVidePleine(0);
            //TesteEmpiler(5);
            //TesteEmpiler(2);
            //TestPile.TesteEmpilerDepiler();
            //TestNbSaisi();
            //Console.WriteLine(Convertir(10,16));
            TestPile.TestePileVide();
            TestPile.TesteEmpiler();
            TestPile.TesteEmpilerDepiler();
            TestPile.TesteConversion();
            TestPile.TesteConversion(154, 2);
            TestPile.TesteConversion(11, 16);
            TestPile.TesteConversion(2986, 16);
            TestPile.TesteConversion(9999, 16);
            Console.WriteLine("Fin du progamme");
            Console.ReadKey();
        }
    }
}
