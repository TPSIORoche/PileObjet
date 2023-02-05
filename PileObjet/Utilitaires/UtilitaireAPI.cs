using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using MesOutils;

namespace Utilitaires
{
    class UtilitaireAPI
    {
        public static String RecupereLoremIpsum(int nbParagraphes)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/text"));
            string url = $"https://loripsum.net/api/{nbParagraphes}/short/plaintext";
            var reponse = client.GetAsync(url).Result;

            if (reponse.IsSuccessStatusCode)
            {
                string responseBody = reponse.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            else
            {
                throw new Exception("Erreur API : " + reponse.StatusCode + " " + reponse.ReasonPhrase);
            }
        }

        internal static string InversePhrase(string phrase)
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
