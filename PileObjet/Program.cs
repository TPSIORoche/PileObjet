using System;

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
            TesteEmpilerDepiler(1);
            Console.WriteLine("Fin du progamme");
            Console.ReadKey();
        }

        static void TestePileVidePleine(int nbElements)
        {
            Pile unePile = new Pile(10);
            if (unePile.PileVide())
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("la pile n'est pas vide");
            }
            if (unePile.PilePleine())
            {
                Console.WriteLine("la pile est pleine");
            }
            else
            {
                Console.WriteLine("la pile n'est pas pleine");
            }
        }

        static void TesteEmpiler(int nbElements)
        {
            //try
            //{
            Pile unePile = new Pile(nbElements);
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
        static void TesteEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                unePile.Empiler(2);
                unePile.Empiler(22);
                int valeurDepilee = (int)unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                unePile.Empiler(17);
                while (!unePile.PileVide())
                {
                    valeurDepilee = (int)unePile.Depiler();
                }
                unePile.Depiler();
                Console.WriteLine(valeurDepilee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
