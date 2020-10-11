using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public static void Main(String[] args)
    {

    /* TODO 
     * Programme principal
     * Matthieu : tes goodies
     * Panier<T>
     */
      //  Jeu j1 = new Jeu("Super Smash bros brawl");
    //   ConsoleJ c1 = new ConsoleJ("PS4");

        LesJeux lj = new LesJeux();
        LesConsoles lc = new LesConsoles();
        Jeu j1 = new Jeu("Mario Kart");
        lj.AjoutJeu(j1);
        lj.Init();
        lc.Init();

        List<Jeu> mario = new List<Jeu>();

        Catalogue cata = new Catalogue(lc, lj);
        mario = cata.GetJeuGenre(Genres.Action_Aventure);
        for(int i = 0; i < mario.Count; i++)
        {
            Console.WriteLine(mario.ElementAt(i));
        }
       // cata.affiche_catalogue();


        // Console.WriteLine(j1.toString()+"\n"+j2.toString());
    }
}