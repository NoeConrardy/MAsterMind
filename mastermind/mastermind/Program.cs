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
                      
            Console.WriteLine("Entrez la couleur de votre ch
            couleurRandom(out int[] programColorsArray);oix");
            string playerColors = Console.ReadLine();
            playerColorToArray(playerColors, out int[] playerColorsArray);
            tableauComparatif(programColorsArray, out int[] programColorsArray_);
            calculePionRouge(programColorsArray_, playerColorsArray, out pionRouge);
            calculePionBlanc(programColorsArray_, playerColorsArray, out pionBlanc);

        }

        //genere des couleurs aux hasards
        static void couleurRandom(out int[] programColorsArray)
        {
            combi = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Random rnd = new Random();
                //int valeur = rnd.Next(1, 7);
                combi[i] = rnd.Next(1, 7);

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