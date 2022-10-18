using System;
using System.Collections.Generic;
using System.Text;

namespace USRS46_Layton
{
    public class Layton : Personnage
    {

        public static List<string> enigmeNameList = new List<string>()
        {
            "1 - Drôles d'oiseaux",
            "2 - Message codé",
            "3 - Une partie mémorable"
        };

        private static Dictionary<string, string> hintDic = new Dictionary<string, string>() {
                { enigmeNameList[0], "Chaque fois que la femme tape dans ses mains, la moitié des oiseaux s'envole et un oiseau revient.\n" +
                 "Layton : Cependant, le nombre d'oiseaux reste le même. La réponse est si simple qu'il est inutile de faire un calcul.\n" },
                { enigmeNameList[1], "Une multiplication et une calculatrice... Vous savez ce qu'il vous reste à faire.\n" },
                { enigmeNameList[2], "Si un joueur trouve 9 paires dans un jeu de 20 cartes, combien de cartes reste-t-il à découvrir ?\n" }
        };

        private List<Enigme> enigmeList = new List<Enigme>()
        {
            new Enigme(enigmeNameList[0], "'Vous tombez bien! J'essaie d'effrayer les oiseaux qui se posent sur les câbles électriques.\n" +
                "A chaque fois que je tape des mains, la moitié des oiseaux s'envole, mais il y en a toujours un qui revient.\n" +
                "J'ai beau taper des mains autant que je peux, je me retrouve toujours avec le même nombre d'oiseaux qu'au départ...\n" +
                "\nA l'origine combien d'oiseaux se trouvaient sur les câbles électriques ?", "2", "Layton : " + hintDic[enigmeNameList[0]]),
            new Enigme(enigmeNameList[1], "En rentrant chez lui, un homme trouve un mot étrange posé à côté de sa calculatrice.\n" +
                "Son colocataire a sans doute voulu lui transmettre un message avant de partir.\n" +
                "Il a écrit '101 X 5'.\n" +
                "Quel mot le colocataire voulait-il faire passer en laissant ce message ?", "SOS", "Layton : " + hintDic[enigmeNameList[1]]),
            new Enigme(enigmeNameList[2], "Trois amis jouent à un jeu de mémoire. Le jeu comporte 10 paires de cartes qu'il faut reconstituer du premier coup.\n" +
                "Le joueur A proclame:\n" +
                "'J'ai trouvé 10 paires d'affilée.'\n" +
                "Le joueur B annonce:\n" +
                "'J'ai trouvé 9 paires d'affilée.'\n" +
                "Quant au joueur C, il déclare:\n" +
                "'J'ai trouvé 8 paires d'affilée.\n" +
                "L'un des joueurs ment, mais lequel ?", "B", "Layton : " + hintDic[enigmeNameList[2]])
        };


        public Layton(string nom, int age) : base(nom, age)
        {

        }






        public override string SePresenter()
        {
            string presentation = this.nom + " : Bonjour ! Féru d'archéologie, je ne refuse jamais un mystère !\n";
            presentation += this.nom + " : Nous nous livrons à un petit jeu quotidien avec mon compagnon, je lui donne une énigme, il essaye de la résoudre.\n";
            presentation += this.nom + " : Maintenant c'est votre tour !\n";
            return presentation;
        }

        public void GiveEnigme(int nbEnigme)
        {
            enigmeList[nbEnigme].Enonce();
        }


    }
}
