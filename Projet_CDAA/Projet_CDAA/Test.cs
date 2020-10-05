using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_CDAA
{
    class Test
    {
        public static void Main(String[] args)
        {
            Jeu j1 = new Jeu();
            Jeu j2 = new Jeu("Mario Kart 8");
            j1.Nom = "Metroïd";
            LesJeux lj = new LesJeux();
            lj.init();
            Catalogue cata = new Catalogue(lj);
            cata.affiche_catalogue();

           // Console.WriteLine(j1.toString()+"\n"+j2.toString());
        }
    }
}
