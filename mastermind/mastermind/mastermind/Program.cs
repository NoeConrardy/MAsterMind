using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void Main(string [] args)
        {
            int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);

        }
        static void ChoixCombi(out int [] combi){
            combi = new int[4];
            for(int i = 0;i <=3; i++) {
                Random rnd = new Random();
                //int valeur = rnd.Next(1, 7);
                combi[i] = rnd.Next(1, 7) ;

            }
        }

        static void Afficher(int[] combi )
        {
            for(int i = 0; i <= 3; i++) {
                Console.Write(combi[i]);

            }
            Console.ReadLine();
        } 

    }
}
