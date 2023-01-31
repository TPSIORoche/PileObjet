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
    class Pile
    {
        /// <summary>
        /// Nombre maximum d'élements de la Pile
        /// </summary>
        private int nbMaxElt;

        /// <summary>
        /// Liste contenant les élements de la Pile
        /// </summary>
        private List<int> elements;

        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            this.elements = new List<int>();
        }

        public bool PileVide()
        {
            return this.elements.Count == 0;
        }

        public bool PilePleine()
        {
            return this.elements.Count - 1 == this.nbMaxElt;
        }

        public void Empiler(int nb)
        {
            if (!(this.PilePleine()))
            {
                this.elements.Add(nb);
            }
            else
            {
                throw new Exception("Impossible d'empiler,pile pleine");
            }
        }

        public int Depiler()
        {
            if (!(this.PileVide()))
            {
                int res = (int)this.elements[elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return res;
            }
            throw new Exception("Impossible de dépiler,pile vide");
        }
    }
}