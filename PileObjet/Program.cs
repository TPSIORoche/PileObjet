﻿using System;
using Utilitaires;

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
            TesteEmpilerDepiler();
            //TestNbSaisi();
            //Console.WriteLine(Convertir(10,16));
            Console.WriteLine("Fin du progamme");
            Console.ReadKey();
        }

        //static void TestePileVidePleine(int nbElements)
        //{
        //    Pile<int> unePile = new Pile<int>(10);
        //    if (unePile.PileVide())
        //    {
        //        Console.WriteLine("la pile est vide");
        //    }
        //    else
        //    {
        //        Console.WriteLine("la pile n'est pas vide");
        //    }
        //    if (unePile.PilePleine())
        //    {
        //        Console.WriteLine("la pile est pleine");
        //    }
        //    else
        //    {
        //        Console.WriteLine("la pile n'est pas pleine");
        //    }
        //}

        //static void TesteEmpiler(int nbElements)
        //{
        //    //try
        //    //{
        //    Pile unePile = new Pile(nbElements);
        //    unePile.Empiler(2);
        //    unePile.Empiler(14);
        //    unePile.Empiler(6);
        //    //}
        //    //catch(Exception ex)
        //    //{
        //    //    Console.WriteLine(ex.Message);
        //    //}
        //}
        static void TesteEmpilerDepiler()
        {
            try
            {
                Pile <string>unePile = new Pile<string>();
                unePile.Empiler("A");
                unePile.Empiler("BB");
                string valeurDepilee = unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                unePile.Empiler("AH");
                Console.WriteLine("valeur dépilée : " + valeurDepilee);

                while (!unePile.PileVide())
                {
                    valeurDepilee = unePile.Depiler();
                }
                unePile.Depiler();
                Console.WriteLine(valeurDepilee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TestNbSaisi()
        {
            int nbSaisi = Utilitaire.SaisirNb();
            Console.WriteLine($"Nombre saisi : {nbSaisi}");
            nbSaisi = Utilitaire.SaisirNb(10);
            Console.WriteLine($"Nombre saisi : {nbSaisi}");
            nbSaisi = Utilitaire.SaisirNb(10,30);
            Console.WriteLine($"Nombre saisi : {nbSaisi}");
        }
        //static string Convertir(int pNbAConvertir, int pNewbase)
        //{
        //    Pile<int> unePile = new Pile<int>();
        //    int a = pNbAConvertir;
        //    int r;
        //    string resultat = "";

        //    while (a > 0)
        //    {
        //        r = a % pNewbase;
        //        unePile.Empiler(r);
        //        a /= pNewbase;
        //    }
        //    string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    while (!unePile.PileVide())
        //    {
        //        //if ((int)unePile.tabEle[unePile.tabElem.Count - 1] > 9)
        //        if (unePile.()>9)
        //        {
        //            int alte = ((int)unePile.Depiler() % pNewbase) - 10;
        //            resultat += alpha[alte];
        //        }
        //        else
        //        {
        //            resultat += unePile.Depiler().ToString();
        //        }
        //    }
        //    return resultat;
        //}

    }
}
