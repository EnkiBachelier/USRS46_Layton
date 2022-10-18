using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public abstract class Personnage
    {
        private string nom;
        private int age;
        private string role;

        public Personnage(string nom, int age, string role)
        {
            this.nom = nom;
            this.age = age;
            this.role = role;
        }

        public virtual string SePresenter()
        {
            return ("Bonjour ! Je m'appelle " + this.nom + " (" + this.age + " ans) !\n");
        }
    }
}
