using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public class Enigme
    {
        #region Déclaration variables
        private string name;
        private string description;
        private string solution;
        private string hint;
        public List<string> nameList;
        #endregion

        #region Constructeur
        public Enigme(string name, string description, string solution, string hint)
        {
            this.name = name;
            this.description = description;
            this.solution = solution;
            this.hint = hint;
        }
        #endregion

        #region Méthodes
        //Affiche l'énoncé, l'indice et la finalité de l'énigme
        public void Enonce()
        {
            //Présente la description de l'énigme
            Console.Write("\nTITRE : " + this.name + "\n\n");
            Console.Write(this.description);
            Console.Write("\n\n");

            //Présente un indice ou non
            Console.Write("Luke : Tu veux un indice ? (oui/non)");
            if (Console.ReadLine() == "oui")
            {
                Console.Write("\n");
                Console.Write(hint);
            }

            //Demande la solution au joueur
            Console.Write("\n");
            Console.Write("Layton : Tu as trouvé la solution donc ? Pour toi c'est : ");

            //Si la solution donnée est la bonne
            if (Console.ReadLine() == this.solution)
            {
                Console.Write("\n");
                Console.Write("Layton : Bravo ! C'est la bonne réponse\n");
                Console.Write("Luke : Waw, tu es trop fort !\n");
            }

            //Si la solution donnée n'est pas la bonne
            else
            {
                Console.Write("\n");
                Console.Write("Layton : Malheureusement, non ! Ce n'est pas la bonne réponse\n");
                Console.Write("Luke : On ne peut pas gagner à tout les coups...\n");
            }
        }
        #endregion
    }
}

