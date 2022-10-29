using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public abstract class Personnage
    {
        #region Déclaration Variables
        public string nom;
        public int age;
        #endregion

        #region Constructeur
        public Personnage(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }
        #endregion

        #region Méthodes
        public abstract string SePresenter();
        #endregion
    }
}
