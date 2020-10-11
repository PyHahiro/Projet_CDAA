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
        this.taille = 0;
    }

    /*
     * Ajout d'un Jeu
     */

    public void AjoutJeu(Jeu j1)
    {
        this.listj.Add(j1);
        this.taille += 1;
    }

    /*
     * Suppression d'un Jeu par son nom
     */

    public void DelJeu(String nom)
    {
        for (int i = 0; i < this.Taille; i++)
        {
            if (this.listj.ElementAt(i).Nom.Equals(nom))
                this.listj.RemoveAt(i);
        }
    }

    /*
     * Accesseur / ToString
     */

    public Jeu GetJeu(int i)
    {
        return listj.ElementAt(i);
    }

    public override String ToString()
    {
        String s = "";
        for (int i = 0; i < listj.Count; i++)
        {
            s += listj.ElementAt(i).ToString();
            s += "\n";
        }
        return s;
    }

    /*
     * Init pour avoir une base avec des jeux sans avoir a construire à chaque fois
     */

    public void Init()
    {
        Jeu j1 = new Jeu("Metroïd", "PEGI 12", "3ds", Genres.Action_Aventure, "Nintendo", 24.99, new DateTime(2005), false);
        Jeu j2 = new Jeu("Mario Kart", "Jeu tout public", "Switch", Genres.Course_Auto,  "Nintendo", 15.99,new DateTime(2008, 6, 1 ,7 ,47,0), true);
        Jeu j3 = new Jeu("Zelda : Breath of the wild");
        j3.Genre = Genres.Action_Aventure;
        this.AjoutJeu(j1);
        this.AjoutJeu(j2);
        this.AjoutJeu(j3);
    }
}
