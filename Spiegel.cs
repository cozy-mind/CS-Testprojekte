using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class Spiegel {
        public static void Run() {
            //Testaufruf
            int[] datensatz = { 1, 2, 3, 4, 5 };
            string datenText = string.Join(", ", datensatz);
            Console.WriteLine(datenText);

            UmgekehrteReihenfolge(ref datensatz);
        }
        public static void UmgekehrteReihenfolge(ref int[] datensatz) {
            int length = datensatz.Length;
            int[] datensatzUmgekehrt = new int[length];

            for (int i = 0; i <= length - 1; i++) {
                datensatzUmgekehrt[i] = datensatz[length - 1 - i];
            }
            string datenTextUmgekehrt = string.Join(", ", datensatzUmgekehrt);
            Console.WriteLine(datenTextUmgekehrt);
        }
    }
}
