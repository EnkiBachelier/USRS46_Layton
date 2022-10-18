using System;

namespace USRS46_Layton
{
    class Program
    {
        static void Main(string[] args)
        {
            Layton theLayton = new Layton("Layton", 32);
            Luke theLuke = new Luke("Luke", 13, theLayton);

            Console.WriteLine(theLayton.SePresenter());
            Console.WriteLine(theLuke.SePresenter());
            theLayton.GiveEnigme(theLuke.AskEnigme());

        }
    }
}
