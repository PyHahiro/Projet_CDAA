using System;
using System.Collections.Generic;
using System.Text;

public enum Etats
{
    Inconnu,
    Mauvais,
    Moyen,
    Bon,
    Neuf,
}
public class JeuRetro : Jeu
{
    /*
         Accesseurs - Mutateurs
     */

    private Boolean notice;
    public Boolean Notice { get { return notice; } set { notice = value; } }
    //--
    private Etats etat;
    public Etats Etat { get { return etat; } set { etat = value; }  }
    //--

    /*
        toString() Affiche des jeux
     */
    public override String ToString()
    {
        return base.ToString() + " | Notice : " + this.notice + " | Etat : " + Enum.GetName(typeof(Etats), etat);
    }
    /*
         Constructeur 0
     */
    public JeuRetro(): base()
    {
        this.notice = false;
        this.etat = Etats.Inconnu;
    }
    /*
        Constructeur bo
    */

    public JeuRetro(String n) : base(n)
    {
        this.notice = false;
        this.etat = Etats.Inconnu;
    }

    /*
        Equals
     */

    public override bool Equals(Object o)
    {
        if (o == null) return false;
        else
        {
            Jeu j2 = o as Jeu;
            return this.Equals(j2);
        }
    }

    public override int GetHashCode()
    {
        return 0;
    }
}
