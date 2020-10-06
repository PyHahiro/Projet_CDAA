using System;
public enum Genres
{
    Aucun,
    Plateforme,
    Action_RPG,
    Action_Aventure,
    Football,
    Course_Auto,
};

public class Jeu:IEquatable<Jeu>
{
    /*
        Accesseurs - Mutateurs
    */
        
    private string nom;
    public string Nom{ get { return nom; } set { nom = value; } }

    private string description;
    public string Description { get { return description; } set { description = value; } }
    //
    private string plateforme;
    public string Plateforme { get { return plateforme; } set { plateforme = value; } }
    //
    private Genres genre;
    public Genres Genre { get { return genre; } set { genre = value; } }
    //
    private string editeur;
    public string Editeur { get { return editeur; } set { editeur = value; } }
    //
    private double prix;
    public double Prix { get { return prix; } set { prix = value; } }
    //
    private DateTime date;
    public DateTime Date { get { return date; } set { date = value; } }
    //
    private Boolean recondition;
    public Boolean Recondition { get { return recondition; } set { recondition = value; } }
    //


    /*
        toString() Affiche des jeux
     */
    public override String ToString()
    {
        return ("Nom : "+this.nom+" | Description : "+this.description+" | Plateforme : "+this.plateforme+" Genre : "+Enum.GetName(typeof(Genres), genre)+" | Editeur : "+this.editeur
            +" | Prix : "+this.prix+" | Date :"+this.date+" | Reconditionné : "+this.recondition );
    }

    /*
        Affichage
     */
    public void Afficher()
    {
        Console.WriteLine(ToString());
    }
    /*
         Constructeur 0
     */
    public Jeu()
    {
        this.nom = "Aucun";
        this.description = "Aucune";
        this.plateforme = "Pas de plateforme connue";
        this.genre = Genres.Aucun;
        this.editeur = "Pas d'editeur";
        this.prix = 0.0;
        this.date = new DateTime();
        this.recondition = false;
    }

    /*
        Constructeur avec Nom
     */

    public Jeu(String n):this()
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

    public override int GetHashCode()
    {
        return 0;
    }
}
