using System;
using System.Collections.Generic;
using System.Text;

namespace Utilitaires
{
    class Utilitaire
    {
        public static int SaisirNb()
        {
            Console.Write($"Veuillez saisir un nombre entier : ");
            return (int.Parse(Console.ReadLine()));
        }

        //public static int SaisirNb(int pMin)
        //{
        //    int nb = 0;
        //    bool cont = true;
        //    while (cont == true)
        //    {
        //        Console.Write($"Veuillez saisir un nombre entier supérieur ou égale à {pMin} : ");
        //        nb = (int.Parse(Console.ReadLine()));
        //        if (nb >= pMin)
        //        {
        //            cont = false;
        //        }
        //        else
        //        {
        //            throw new Exception($"La valeur entré n'est pas supérieur ou égale à {pMin}");
        //        }
        //    }
        //    return nb;
        //}

        //public static int SaisirNb(int pMin,int pMax)
        //{
        //    int nb = 0;
        //    bool cont = true;
        //    while (cont == true)
        //    {
        //        Console.Write($"Veuillez saisir un nombre entier compris entre {pMin} et {pMax} : ");
        //        nb = (int.Parse(Console.ReadLine()));
        //        if (nb > pMin && nb<pMax)
        //        {
        //            cont = false;
        //        }
        //        else
        //        {
        //            throw new Exception($"La valeur entré n'est pas compris entre {pMin} et {pMax}");
        //        }
        //    }
        //    return nb;
        //}

        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.Write($"Veuillez saisir un nombre entier supérieur à {pMin} : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin);
            return nb;
        }

        public static int SaisirNb(int pMin,int pMax)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.Write($"Veuillez saisir un nombre entier compris entre {pMin} et {pMax} : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb <= pMin || nb >= pMax);
            return nb;
        }
    }
}
