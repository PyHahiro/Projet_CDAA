using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Catalogue
{
	private DateTime maj; 
	public DateTime Maj { get { return maj; } set { maj = value; } }
	//
	private LesJeux lj;
	public LesJeux Lj { get { return lj; } set { lj = value; } }
	//
	private LesConsoles lc;
	public LesConsoles Lc { get { return lc; } set { lc = value; } }
	//
	private List<Object> leCatalogue;
	public List<Object> LeCatalogue { get { return leCatalogue; } set { leCatalogue = value; } }
	/*
	 *  Constructeur de base
	 */
	public Catalogue()
	{
		this.lj = new LesJeux();
		this.lc = new LesConsoles();
		lc.Init();
		lj.Init();
		InitCatalogue();
	}

	/*
	 *  Constructeur complet
	 */

	public Catalogue(LesConsoles lesconsoles, LesJeux lesjeux)
	{
		this.lj = lesjeux;
		this.lc = lesconsoles;
		InitCatalogue();
	}

	/*
	 * Mis à jour du Catalogue
	 */

	public void InitCatalogue()
	{
		List<Object> cat = new List<Object>();
		//Les jeux
		for (int i = 0; i < lj.Taille; i++) cat.Add(this.lj.GetJeu(i));
		//Puis les consoles
		for (int i = 0; i < lc.Taille; i++) cat.Add(this.lc.GetConsole(i));
		this.LeCatalogue = cat;
	}

	/*
	 * Constructeur LesJeux
	 */

	public Catalogue(LesJeux lesjeux)
    {
		this.lj = lesjeux;
		this.lc = new LesConsoles();
		lc.Init();
    }

	/*
	 * Constructeur LesConsoles
	 */

	public Catalogue(LesConsoles lesconsoles)
    {
		this.lj = new LesJeux();
		lj.Init();
		this.lc = lesconsoles;
    }

	public void affiche_catalogue()
    {
		InitCatalogue();
		foreach(object o in this.LeCatalogue)
        {
			Console.WriteLine(""+o.ToString());
			Console.WriteLine("\n =-------------------------------= \n");
        }
	}

	/*
	 *  Ajout d'un élément au catalogue
	 */

	public void AjoutJeu(Jeu j)
	{
		lj.AjoutJeu(j);
	}

	public void AjoutConsole(ConsoleJ c)
    {
		lc.AjoutConsole(c);
    }

	/*
	 * Suppression par nom
	 */

	public void DelJeu(String nom)
    {
		lj.DelJeu(nom);
    }

	public void DelConsole(String nom)
    {
		lc.DelConsole(nom);
    }

	/*
	 * Récupération par le nom
	 */

	public LesJeux GetJeuNom(String nom)
    {
		LesJeux ljres = new LesJeux();
		for(int i = 0; i < lj.Taille; i++)
        {
			if (this.lj.GetJeu(i).Nom.Equals(nom)) ljres.AjoutJeu(this.lj.GetJeu(i)); 
        }
		return ljres;
    }

	public List<ConsoleJ> GetConsoleNom(String nom)
    {
		List<ConsoleJ> consoleRecup = new List<ConsoleJ>();
		for(int i = 0; i < lc.Taille; i++)
        {
			if (this.lc.GetConsole(i).Nom.Equals(nom)) consoleRecup.Add(this.lc.GetConsole(i));
        }
		return consoleRecup;
    }

	/*
	 * Récupération par le Genre
	 */

	public LesJeux GetJeuGenre(Genres genre)
    {
		LesJeux jeuRecup = new LesJeux();
		for(int i= 0; i < lj.Taille; i++)
        {
			if (this.lj.GetJeu(i).Genre.Equals(genre)) jeuRecup.AjoutJeu(this.lj.GetJeu(i));
        }
		return jeuRecup;
	}

}
