using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public abstract class Personnage
    {
        public string nom;
        public int age;

        public Personnage(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }

        public abstract string SePresenter();
    }
}
