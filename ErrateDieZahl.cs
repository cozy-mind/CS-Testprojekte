using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class ErrateDieZahl {
        public static void Run() {
            //Testaufruf
            RateSpiel(1, 100);
        }
        public static void RateSpiel(int min, int max) {
            Random rand = new Random();
            int zahl = rand.Next(min, max + 1);
            int guess = 0;
            while (zahl != guess) {
                Console.WriteLine($"Errate die gesuchte zahl zwischen {min} und {max}.");
                guess = Convert.ToInt16(Console.ReadLine());
                if (guess < zahl) {
                    Console.WriteLine("Zu niedrig!");
                }
                else if (guess > zahl) {
                    Console.WriteLine("Zu hoch!");
                }
            }

            Console.WriteLine("Glückwunsch Sie haben die Zahl erraten.");
        }
    }
}
