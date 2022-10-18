using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public class Enigme
    {
        string name;
        string description;
        string solution;
        string hint;

        public List<string> nameList;
        public Enigme(string name, string description, string solution, string hint)
        {
            this.name = name;
            this.description = description;
            this.solution = solution;
            this.hint = hint;
        }

        public void Enonce()
        {
            Console.Write("\nTITRE : " + this.name + "\n\n");
            Console.Write(this.description);
            Console.Write("\n\n");
            Console.Write("Luke : Tu veux un indice ? (oui/non)");
            if (Console.ReadLine() == "oui")
            {
                Console.Write("\n");
                Console.Write(hint);
            }
            Console.Write("\n");
            Console.Write("Layton : Tu as trouvé la solution donc ? Pour toi c'est : ");
            if (Console.ReadLine() == this.solution)
            {
                Console.Write("\n");
                Console.Write("Layton : Bravo ! C'est la bonne réponse\n");
                Console.Write("Luke : Waw, tu es trop fort !\n");
            }
            else
            {
                Console.Write("\n");
                Console.Write("Layton : Malheureusement, non ! Ce n'est pas la bonne réponse\n");
                Console.Write("Luke : On ne peut pas gagner à tout les coups...\n");
            }

        }

    }
}

