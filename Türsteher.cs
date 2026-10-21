using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class Türsteher {
        public static void Run() {
            //Testaufruf
            int[] altersListe = { 17, 19, 15, 25, 28, 33, 23, 41 };
            string listeTextform = string.Join(", ", altersListe);
            Console.WriteLine($"Alter der Gäste:\n{listeTextform}");

            Alterskontrolle(ref altersListe);
        }
        public static void Alterskontrolle(ref int[] liste) {
            
            int minderjährige = 0;
            //alle über 18
            foreach (int alter in liste) {
                if (alter <= 17) {
                    minderjährige++;
                }
            }
            Console.WriteLine($"{minderjährige} minderjährige wurden abgewiesen.");
        }
    }
}
