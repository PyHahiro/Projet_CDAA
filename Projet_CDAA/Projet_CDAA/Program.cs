using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_CDAA
{
    class Program
    {
        public static void Main(String[] args)
        {
            Jeu j2 = new Jeu("Mario Kart 7");
            j2.Description = "Bonjour je suis une description";
            JeuRetro jr1 = new JeuRetro("Mario kart double dash");
            ConsoleJ c1 = new ConsoleJ("PS4");

            LesJeux lj = new LesJeux();
            lj.ajoutJeu(jr1);
            lj.ajoutJeu(j2);

            lj.init();
            Catalogue cata = new Catalogue(lj);
            cata.affiche_catalogue();
            Console.WriteLine(c1.ToString());

           // Console.WriteLine(j1.toString()+"\n"+j2.toString());
        }
    }
}
