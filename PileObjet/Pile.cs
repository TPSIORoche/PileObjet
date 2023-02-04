using System;
using System.Collections.Generic;
using System.Text;

namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers
    /// On ajoute après le dernier élément ajouté
    /// On retire toujours le dernier élément ajouté
    /// </summary>
    class Pile<T>
    {
        /// <summary>
        /// Liste contenant les élements de la Pile
        /// </summary>
        private List<T> elements;

        public Pile()
        {
            this.elements = new List<T>();
        }

        public bool PileVide()
        {
            return this.elements.Count == 0;
        }

        public int Count { get => this.elements.Count; }


        /// <param name="valeur">Valeur à empiler</param>
        public void Empiler(T valeur)
        {
            this.elements.Add(valeur);
        }

        public int Depiler()
        {
            if (!(this.PileVide()))
            {
                var res = this.elements[elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return res;
            }
            throw new Exception("Impossible de dépiler,pile vide");
        }
    }
}