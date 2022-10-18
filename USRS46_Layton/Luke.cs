using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public class Luke : Personnage
    {

        private int nbEnigme;
        public Layton theLayton;

        public Luke(string nom, int age, Layton theLayton) : base(nom, age)
        {
            this.nbEnigme = 0;
            this.theLayton = theLayton;
        }

        public override string SePresenter()
        {
            string presentation = this.nom + " : Comme j'ai moins d'expérience que le Professeur, il m'entraîne régulièrement en me posant des énigmes !\n";
            presentation += this.nom + " : Maintenant c'est votre tour !\n";
            return presentation;
        }

        public int AskEnigme()
        {
            Console.Write(this.nom + " : Dites-moi l'énigme que vous souhaitez résoudre !\n\n");
            for (int i = 0; i<Layton.enigmeNameList.Count; i++)
            {
                if (i == 0)
                    Console.Write("\n");
                Console.Write(Layton.enigmeNameList[i] + "\n");
                if (i == Layton.enigmeNameList.Count)
                    Console.Write("\n\n");
            }
            Console.Write(this.nom + " : Alors partenaire ? Tu choisis l'énigme n°");
            nbEnigme = int.Parse(Console.ReadLine());
            return nbEnigme-1;
        }

    }
}
