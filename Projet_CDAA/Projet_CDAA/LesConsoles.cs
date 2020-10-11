using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LesConsoles
{
    private int taille;
    public int Taille { get { return listC.Count; } set { taille = value; } }

    private List<ConsoleJ> listC;

    public LesConsoles()
    {
        listC = new List<ConsoleJ>();
        this.taille = 0;
    }

    /*
     * Ajout d'une Console
     */

    public void AjoutConsole(ConsoleJ c1)
    {
        this.listC.Add(c1);
        this.Taille += 1;
    }

    /*
     * Suppression d'une Console par son Nom
     */

    public void DelConsole(String nom)
    {
        for (int i = 0; i < this.Taille; i++)
        {
            if (this.listC.ElementAt(i).Nom.Equals(nom))
                this.listC.RemoveAt(i);
        }
    }

    /*
     * Accesseur / ToString
     */

    public ConsoleJ GetConsole(int i)
    {
        return listC.ElementAt(i);
    }

    public override String ToString()
    {
        String s = "";
        for (int i = 0; i < listC.Count; i++)
        {
            s += listC.ElementAt(i).ToString();
            s += "\n";
        }
        return s;
    }

    /*
     *  Pre-remplissage d'une liste de consoles pour notre Catalogue
     */

    public void Init()
    {
        ConsoleJ c1 = new ConsoleJ("PS4");
        ConsoleJ c2 = new ConsoleJ("Switch");
        ConsoleJ c3 = new ConsoleJ("Xbox One");
        this.AjoutConsole(c1);
        this.AjoutConsole(c2);
        this.AjoutConsole(c3);
    }
}
