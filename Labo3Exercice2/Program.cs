using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3Exercice2
{
    class Program
    {
        static Random generateurNb = new Random();
        static void Main(string[] args)
        {
            string mesDixMots = "algorithme programmation decryptage conception analyse codage anticonstitutionnellement langage debogage resolution";
            string[] lesMots;



            lesMots = mesDixMots.Split(' ');
            int choix = (int)generateurNb.Next(0, 10);
            string motChoisit = lesMots[choix];
            Console.WriteLine(motChoisit);
            int lgrMot = motChoisit.Length;
            int[] tabAff = new int[lgrMot];
            for(int i =0; i< tabAff.Length; i++)
            {
                tabAff[i] = 0;
            }
            do
            {
                
                for (int i = 0; i < tabAff.Length; i++)
                {
                    if (tabAff[i] == 0)
                    {
                        Console.Write(" _ ");
                    }
                    else
                    {
                        Console.Write(" " + motChoisit[i] + " ");
                    }
                }
            } while (tabAff.Contains(0));
            /*string[] test2;
            test = Console.ReadLine();
            test2 = test.Split(' ');
              for (int i = 0; i < test2.Length; i++)
              {
                  Console.WriteLine(test2[i]);
              }*/

        }
    }
}
