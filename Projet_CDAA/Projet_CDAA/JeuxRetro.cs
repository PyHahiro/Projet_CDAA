using System;
using System.Collections.Generic;
using System.Text;


public enum Genres
{
    Aucun,
    Plateforme,
    Action_RPG,
    Action_Aventure,
    Football,
    Course_Auto,
};

public enum Etats
{
    Inconnu,
    Mauvais,
    Moyen,
    Bon,
    Neuf,
}
public class JeuxRetro
{
    /*
         Accesseurs - Mutateurs
     */

    private string nom;
    public string Nom { get { return nom; } set { nom = value; } }
    //--
    private string description;
    public string Description { get { return description; } set { description = value; } }
    //--
    private string plateforme;
    public string Plateforme { get { return plateforme; } set { plateforme = value; } }
    //--
    private Genres genre;
    public Genres Genre { get { return genre; } set { genre = value; } }
    //--
    private string editeur;
    public string Editeur { get { return editeur; } set { editeur = value; } }
    //--
    private double prix;
    public double Prix { get { return prix; } set { prix = value; } }
    //--
    private DateTime date;
    public DateTime Date { get { return date; } set { date = value; } }
    //--
    private Boolean recondition;
    public Boolean Recondition { get { return recondition; } set { recondition = value; } }
    //--
    private Boolean notice;
    public Boolean Notice { get { return notice; } set { notice = value; } }
    //--
    private Etats etat;
    public Etats Etat { get { return etat; } set { etat = value; }  }
    //--

    /*
        toString() Affiche des jeux
     */
    public String toString()
    {
        return ("Nom : " + this.nom + " | Description : " + this.description + " | Plateforme : " + this.plateforme + " Genre : " + Enum.GetName(typeof(Genres), genre) + " | Editeur : " + this.editeur
            + " | Prix : " + this.prix + " | Date : " + this.date + " | Reconditionné : " + this.recondition+ " | Notice : "+this.notice + " | Etat : "+Enum.GetName(typeof(Etats), etat));
    }
    /*
        Affichage
     */
    public void afficher()
    {
        Console.WriteLine(toString());
    }
    /*
         Constructeur 0
     */
    public JeuxRetro()
    {
        this.nom = "Aucun";
        this.description = "Aucune";
        this.plateforme = "Pas de plateforme connue";
        this.genre = Genres.Aucun;
        this.editeur = "Pas d'editeur";
        this.prix = 0.0;
        this.date = new DateTime();
        this.recondition = false;
        this.notice = false;
        this.etat = Etats.Inconnu;
    }
    /*
        Constructeur bo
    */

    public JeuxRetro(String n) : this()
    {
        this.nom = n;
    }

    /*
        Equals
     */
    public bool Equals(Jeu j)
    {
        return this.Nom.Equals(j.Nom);
    }

    public override bool Equals(Object o)
    {
        if (o == null) return false;
        else
        {
            Jeu j2 = o as Jeu;
            return this.Equals(j2);
        }
    }
}
