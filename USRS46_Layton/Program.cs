using System;

namespace USRS46_Layton
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration Variables
            Layton theLayton = new Layton("Layton", 32);
            Luke theLuke = new Luke("Luke", 13, theLayton);
            #endregion

            #region Lancement Textes & Jeu
            Console.WriteLine(theLayton.SePresenter());
            Console.WriteLine(theLuke.SePresenter());
            theLayton.GiveEnigme(theLuke.AskEnigme());
            #endregion
        }
    }
}
