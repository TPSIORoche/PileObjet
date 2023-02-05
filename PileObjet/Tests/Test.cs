using System;
using System.Collections.Generic;
using System.Text;
using MesOutils;
using Utilitaires;

namespace PileObjet.Tests
{
    internal abstract class TestPile
    {
        public static void TestePileVide()
        {
            Pile<int> unePile = new Pile<int>();
            if (unePile.PileVide())
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("la pile n'est pas vide");
            }
        }

        public static void TesteEmpiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                unePile.Empiler(2);
                unePile.Empiler(14);
                unePile.Empiler(6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void TesteEmpilerDepiler()
        {
            try
            {
                Pile<string> unePile = new Pile<string>();
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

        public static void TestNbSaisi()
        {
            int nbSaisi = Utilitaire.SaisirNb();
            Console.WriteLine($"Nombre saisi : {nbSaisi}");
            nbSaisi = Utilitaire.SaisirNb(10);
            Console.WriteLine($"Nombre saisi : {nbSaisi}");
            nbSaisi = Utilitaire.SaisirNb(10, 30);
            Console.WriteLine($"Nombre saisi : {nbSaisi}");
        }

        //public static string TesteConversion()
        //{
        //    int a = Utilitaire.SaisirNb(0);
        //    int b = Utilitaire.SaisirNb(1,17);
        //    return Utilitaire.Convertir(a, b);
        //}

        //public static string TesteConversion(int pNbAConvertir, int pNewbase)
        //{
        //    return Utilitaire.Convertir(pNbAConvertir,pNewbase);
        //}

        public static void TesteConversion()
        {
            Console.WriteLine("Saisie du nombre à convertir. ");
            int nbAConvertir = Utilitaire.SaisirNb(0);
            Console.WriteLine("Saisie de la nouvelle base. ");
            int newBase = Utilitaire.SaisirNb(2, 16);
            TesteConversion(nbAConvertir, newBase);
        }
        public static void TesteConversion(int nbAConvertir,int newBase)
        {
            try
            {
                string valeurConvertie = Utilitaire.Convertir(nbAConvertir, newBase);
                Console.WriteLine("ValeurConvertie convertie : " + valeurConvertie);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
