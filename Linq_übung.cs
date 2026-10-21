using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_testprojekte {
    internal class Linq_übung {
        public static void Run() {
            //Testaufruf
            List<Spieler> spielerListe = new List<Spieler>() {
                new Spieler{Name = "John", Score = 1300},
                new Spieler{Name = "Janet", Score = 980},
                new Spieler{Name = "Thomas", Score = 1100},
                new Spieler{Name = "Anton", Score = 460},
                new Spieler{Name = "Ralph", Score = 1005}
            };
            string listeText = string.Join(", ", spielerListe.Select(p => $"{p.Name} ({p.Score})"));
            Console.WriteLine($"Liste aller Spieler:\n{listeText}\n");

            //Zeigt alle Werte über 1000 an
            ZeigeHighscoreWerte(spielerListe, 1000);
        }
        public static void ZeigeHighscoreWerte(List<Spieler> liste, int minScore) {

            // filtert liste nach werten >= "minScore" punkten
            List<Spieler> gefilterteListe = liste
                .Where(s => s.Score > 1000)
                .OrderByDescending(s => s.Score)
                .ToList();
            ;
            string listeTextGefiltert = string.Join(", ", gefilterteListe.Select(p => $"{p.Name} ({p.Score})"));
            Console.WriteLine($"Liste aller Spieler über {minScore} Punkten:\n{listeTextGefiltert}");
        }
    }
}
