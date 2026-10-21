using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class Statistik {
        public static void Run() {
            //Testaufrufe
            Console.WriteLine($"Filtere folgendes Array nach der höchsten Zahl:\n");
            int[] highscore = { 370, 230, 480, 870, 1090, 980 };
            foreach(int score in highscore) {
                Console.Write($"{score}, ");
            }

            Highscore(ref highscore);
        }

        public static void Highscore(ref int[] liste) {
            int temp = liste[0];
            for (int i = 0; i < liste.Length; i++) {
                if (temp < liste[i]) {
                    temp = liste[i];
                }
            }
            Console.WriteLine($"\nHighscore: {temp}");
        }
    }
}
