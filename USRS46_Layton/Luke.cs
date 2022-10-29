using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public class Luke : Personnage
    {

        #region Déclaration Variables
        private int nbEnigme;
        public Layton theLayton;
        #endregion

        #region Constructeur
        public Luke(string nom, int age, Layton theLayton) : base(nom, age)
        {
            this.nbEnigme = 0;
            this.theLayton = theLayton;
        }
        #endregion

        #region Méthodes
        //Retourne un texte de présentation (string)
        public override string SePresenter()
        {
            string presentation = this.nom + " : Comme j'ai moins d'expérience que le Professeur, il m'entraîne régulièrement en me posant des énigmes !\n";
            presentation += this.nom + " : Maintenant c'est votre tour !\n";
            return presentation;
        }

        //Retourne le numéro de l'énigme choisie (-1 car les énigmes sont stockées dans un tableau commençant à 0) après avoir écrit leur titre. 
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
        #endregion
    }
}
