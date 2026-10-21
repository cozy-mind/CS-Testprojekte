using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class TauscheWerte {
        public static void Run() {
            //Testaufrufe
            int lebenspunkte = 100;
            int schildpunkte = 25;

            Console.WriteLine($"Werte vor Tausch\nLP: {lebenspunkte}, SP: {schildpunkte}");

            TauschWerte(ref lebenspunkte, ref schildpunkte);
            Console.WriteLine($"Werte nach Tausch\nLP: {lebenspunkte}, SP: {schildpunkte}");
        }
        public static void TauschWerte(ref int ziel1, ref int ziel2) {
            int temp = ziel1;
            ziel1 = ziel2;
            ziel2 = temp;
        }

    }
}
