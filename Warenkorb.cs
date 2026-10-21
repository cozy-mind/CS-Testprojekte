using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class Warenkorb {
        public static void Run() {
            //Korrekte Darstellung von "€"
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Testaufrufe
            double ergebnis1 = BerechneSumme(19.99, 4.49, 36.99);
            double ergebnis2 = BerechneSumme(); // Test für leeren Warenkorb

            Console.WriteLine($"Summe 1: {ergebnis1} €");
            Console.WriteLine($"Summe 2: {ergebnis2} €");
        }

        static double BerechneSumme(params double[] warenkorb) {
            if (warenkorb.Length == 0) {
                return 0.0;
            }
            double summe = 0;
            for (int i = 0; i < warenkorb.Length; i++) {
                summe += warenkorb[i];
            }
            return summe;
        }
    }
}
