using System;

public class Catalogue
{
	private DateTime maj; 
	public DateTime Maj { get { return maj; } set { maj = value; } }

	private LesJeux lj;
	public LesJeux Lj { get { return lj; } set { lj = value; } }

	public Catalogue()
	{
		this.lj = new LesJeux();
		lj.init();

	}

	public Catalogue(LesJeux lesjeux)
    {
		this.lj = lesjeux;
    }

	public void affiche_catalogue()
    {
        for(int i = 0; i < lj.Taille; i++)
		{
			Console.WriteLine("\n" + this.lj.getJeu(i).ToString());

        }
		Console.WriteLine("~-~");

	}
}
