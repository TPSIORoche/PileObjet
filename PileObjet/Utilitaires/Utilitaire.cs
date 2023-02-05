using System;
using System.Collections.Generic;
using System.Text;
using MesOutils;

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

        public static string Convertir(int pNbAConvertir, int pNewbase)
        {
            if (pNbAConvertir <= 0)
            {
                throw new Exception("Le nombre à convertir doit être strictement positif");
            }
            if (pNewbase<2 || pNewbase>16)
            {
                throw new Exception("La nouvelle base doit être comprise entre 2 et 16");
            }
            Pile<int> unePile = new Pile<int>();
            int a = pNbAConvertir;
            int r;
            string resultat = "";

            while (a > 0)
            {
                r = a % pNewbase;
                unePile.Empiler(r);
                a /= pNewbase;
            }
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (!unePile.PileVide())
            {
                //if ((int)unePile.tabEle[unePile.tabElem.Count - 1] > 9)
                int tempo = unePile.Depiler();
                if (tempo > 9)
                {
                    int alte = (tempo % pNewbase) - 10;
                    resultat += alpha[alte];
                }
                else
                {
                    resultat += tempo.ToString();
                }
            }
            return resultat;
        }

        public static string InversePhrase(string phrase)
        {
            Pile<string> maPile = new Pile<string>();
            var tab = phrase.Split(' ');
            foreach (string mot in tab)
            {
                maPile.Empiler(mot);
            }
            string message = "";
            while (!maPile.PileVide())
            {
                message += " " + maPile.Depiler();
            }
            return message;
        }
    }
}
