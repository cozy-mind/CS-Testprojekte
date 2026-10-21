using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class WechselgeldRechner {
        public static void Run() {
            //Testaufruf
            Auszahlung();
        }

        public static void Auszahlung() {
            Console.WriteLine("Welchen Geldbetrag möchten Sie abbuchen?");
            int betrag = Convert.ToInt32(Console.ReadLine());
            int zehnEuroScheine = betrag / 10;
            int münzen = betrag % 10;
            Console.WriteLine($"Sie erhalten {zehnEuroScheine} 10-Euro Scheine und" +
                $" {münzen} 1-Euro Münzen.");
        }
    }
}
