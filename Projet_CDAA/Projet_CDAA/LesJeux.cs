using System;
using System.Collections.Generic;
using System.Linq;

public class LesJeux
{
    private int taille;
    public int Taille { get { return listj.Count; } set { taille = value; } }

    private List<Jeu> listj;
    public LesJeux()
    {
        listj = new List<Jeu>();

    }
    public void ajoutJeu(Jeu j1)
    {
        this.listj.Add(j1);
    }

    public Jeu getJeu(int i)
    {
        return listj.ElementAt(i);
    }

    public String toString()
    {
        String s = "";
        for (int i = 0; i < listj.Count; i++)
        {
            s += listj.ElementAt(i).toString();
            s += "\n";
        }
        return s;
    }


    public void init()
    {
        Jeu j1 = new Jeu("Metroïd");
        Jeu j2 = new Jeu("Mario Kart");
        Jeu j3 = new Jeu("Zelda : Breath of the wild");
        this.Taille = 3;
        this.ajoutJeu(j1);
        this.ajoutJeu(j2);
        this.ajoutJeu(j3);
    }
}
