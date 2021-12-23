using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pionRouge = 0;
            int pionBlanc = 0;
            int manche = 1;

            couleurRandom(out int[] programColorsArray);

            while (pionRouge != 4 && manche <= 12)
            {
                Console.WriteLine("Entrez la couleur de votre choix");
                string playerColors = Console.ReadLine();
                //Fonction qui met les couleurs du joueur vers un tableau
                playerColorToArray(playerColors, out int[] playerColorsArray);
                //Fonction qui créé un tableau comparatif
                tableauComparatif(programColorsArray, out int[] programColorsArray_);
                //Fonction qui calcule le nombre de pion rouge
                calculePionRouge(programColorsArray_, playerColorsArray, out pionRouge);
                //Fonction qui calcule ne nombre de pion blanc
                calculePionBlanc(programColorsArray_, playerColorsArray, out pionBlanc);

                Console.WriteLine($"pion rouge: {pionRouge}");
                Console.WriteLine($"pion blanc: {pionBlanc}");

                //Vérification piont rouge + manche
                if (pionRouge == 4)
                {
                    Console.WriteLine("Bien joué vous avez gagné !");
                    Console.ReadLine();
                }
                else
                {
                    manche++;
                    if (manche > 12)
                    {
                        Console.WriteLine("Vous avez perdu !");
                        Console.ReadLine();
                    }
                }
            }
        }

        //genere des couleurs aux hasards
        static void couleurRandom(out int[] programColorsArray)
        {
            programColorsArray = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Random rnd = new Random();
                //int valeur = rnd.Next(1, 7);
                programColorsArray[i] = rnd.Next(1, 7);

            }
        }
        /*static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(combi[i]);

            }
            Console.ReadLine();
        }*/

        //Reponse du joueur vers un tableau
        static void playerColorToArray(string reponseColors, out int[] playerColorsArray)
        {
            playerColorsArray = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                playerColorsArray[i] = int.Parse(reponseColors[i].ToString());
            }
        }

        //calculer les pions rouges
        static void calculePionRouge(int[] programColorsArray_, int[] playerColorsArray, out int pionRouge)
        {
            pionRouge = 0;
            for (int i = 0; i <= 3; i++)
            {
                if (programColorsArray_[i] == playerColorsArray[i])
                {
                    programColorsArray_[i] = -1;
                    playerColorsArray[i] = -2;
                    pionRouge++;
                }

            }
        }

        //calculer les pions blancs 
        static void calculePionBlanc(int[] programColorsArray_, int[] playerColorsArray, out int pionBlanc)
        {
            pionBlanc = 0;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (programColorsArray_[i] == playerColorsArray[j])
                    {
                        playerColorsArray[i] = -2;
                        pionBlanc++;
                    }
                }
            }
        }

        //tableau comparatif qui ajoute de dans.
        static void tableauComparatif(int[] programColorsArray, out int[] programColorsArray_)
        {
            programColorsArray_ = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                programColorsArray_[i] = programColorsArray[i];
            }
        }

    }
}