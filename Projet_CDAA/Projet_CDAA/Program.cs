using Projet_CDAA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    public static void Main(String[] args)
    {

    Catalogue catalogue = new Catalogue();
    int quit = 0;


        Panier<Jeu> jp = new Panier<Jeu>();
        jp.AjoutPanier(new Jeu("Bermeno"));
        jp.AjoutPanier(new Jeu("Metroid"));
        jp.AjoutPanier(new Jeu("Anemo"));
        jp.sortByName();
        jp.affichePanier();
        /* TODO 
         * Programme principal
         * Matthieu : tes goodies
         * Panier<T>
         * Jonathan : Console a faire dans le main
         *            la methode getConsoleNom a modifier pour return LesConsoles
         * option : faire repeter les operation si celle-ci n'est pas correctement effectuer
         */

        while (quit != 4)
        {  

            Console.WriteLine("1. Ajouter");
            Console.WriteLine("2. Retirer");
            Console.WriteLine("3. Rechercher");
            Console.WriteLine("4. Quitter");
            String res = Console.ReadLine();
            int choix = int.Parse(res);
            Console.WriteLine("");


            switch (choix)
                {

                    /*
                     * Ajout
                     */

                    case 1: {
                        Console.WriteLine("1. Ajouter_Jeu");
                        Console.WriteLine("2. Ajouter_Jeu_retro");
                        Console.WriteLine("3. Ajouter_Goodies"); 
                        Console.WriteLine("4. Retour");
                        String resa = Console.ReadLine();
                        int choixa = int.Parse(resa);
                        Console.WriteLine("");

                        /*
                         * Ajout d'un jeu 
                         */

                        if (choixa == 1)
                        {
                            Jeu j = new Jeu();
                                
                            Console.WriteLine("Nom du jeu : ");
                            j.Nom = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Description : ");
                            j.Description = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Plateforme : ");
                            j.Plateforme = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Taper le numéro du genre :");
                            Console.WriteLine("1. Aucun");
                            Console.WriteLine("2. Plateforme");
                            Console.WriteLine("3. Action_RPG");
                            Console.WriteLine("4. Action_Aventure");
                            Console.WriteLine("5. Football");
                            Console.WriteLine("6. Course_Auto");
                            switch(int.Parse(Console.ReadLine()))
                            {
                                case 1: {};break;
                                case 2: {j.Genre = Genres.Plateforme;};break;
                                case 3: {j.Genre = Genres.Action_RPG;};break;
                                case 4: {j.Genre = Genres.Action_Aventure;};break;
                                case 5: {j.Genre = Genres.Football;};break;
                                case 6: {j.Genre = Genres.Course_Auto;};break;
                            }
                            Console.WriteLine(""); ;
                                
                            Console.WriteLine("Editeur : ");
                            j.Editeur = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Prix : ");
                            j.Prix = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine("");

                            String d = "01/01/1900"; 
                            Console.WriteLine("Entré la date en suivant le Model dd/MM/yyyy : ");
                            d = Console.ReadLine();
                            j.Date = DateTime.ParseExact(d,"dd/MM/yyyy",null);
                            Console.WriteLine("");

                            Console.WriteLine("Reconditionné (O/N) : ");
                            String resR = Console.ReadLine();
                            if(resR.Equals("O"))
                                {
                                    j.Recondition = true;
                            }
                            else if(resR.Equals("N"))
                                {
                                    j.Recondition = false;
                            }
                            Console.Clear();

                            catalogue.AjoutJeu(j);
                        }

                        /*
                         * Ajout Jeu retro
                         */

                        if(choixa == 2)
                        {
                            JeuRetro j = new JeuRetro();

                            Console.WriteLine("Nom du jeu : ");
                            j.Nom = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Description : ");
                            j.Description = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Plateforme : ");
                            j.Plateforme = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Taper le numéro du genre :");
                            Console.WriteLine("1. Aucun");
                            Console.WriteLine("2. Plateforme");
                            Console.WriteLine("3. Action_RPG");
                            Console.WriteLine("4. Action_Aventure");
                            Console.WriteLine("5. Football");
                            Console.WriteLine("6. Course_Auto");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1: { }; break;
                                case 2: { j.Genre = Genres.Plateforme; }; break;
                                case 3: { j.Genre = Genres.Action_RPG; }; break;
                                case 4: { j.Genre = Genres.Action_Aventure; }; break;
                                case 5: { j.Genre = Genres.Football; }; break;
                                case 6: { j.Genre = Genres.Course_Auto; }; break;
                            }
                            Console.WriteLine("");

                            Console.WriteLine("Editeur : ");
                            j.Editeur = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Prix : ");
                            j.Prix = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine("");

                            String d = "01/01/1900";
                            Console.WriteLine("Entré la date en suivant le Model dd/MM/yyyy : ");
                            d = Console.ReadLine();
                            j.Date = DateTime.ParseExact(d, "dd/MM/yyyy", null);
                            Console.WriteLine("");

                            Console.WriteLine("Reconditionné (O/N) : ");
                            String resR = Console.ReadLine();
                            if (resR.Equals("O"))
                            {
                                j.Recondition = true;
                            }
                            else if (resR.Equals("N"))
                            {
                                j.Recondition = false;
                            }
                            Console.WriteLine("");

                            Console.WriteLine("Notice (O/N) : ");
                            resR = Console.ReadLine();
                            if (resR.Equals("O"))
                            {
                                j.Notice = true;
                            }
                            else if (resR.Equals("N"))
                            {
                                j.Notice = false;
                            }
                            Console.WriteLine("");

                            Console.WriteLine("Taper le numéro de l'etat du jeu :");
                            Console.WriteLine("1. Inconnue");
                            Console.WriteLine("2. Mauvais");
                            Console.WriteLine("3. Moyen");
                            Console.WriteLine("4. Bon");
                            Console.WriteLine("5. Neuf");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1: { }; break;
                                case 2: { j.Etat = Etats.Mauvais; }; break;
                                case 3: { j.Etat = Etats.Moyen; }; break;
                                case 4: { j.Etat = Etats.Bon; }; break;
                                case 5: { j.Etat = Etats.Neuf; }; break;
                            }
                            Console.Clear();

                            catalogue.AjoutJeu(j);
                        }

                        /*
                         * Goodies
                         */

                        if(choixa == 3)
                        {
                            Goodies g = new Goodies();

                            Console.WriteLine("Nom du goodies : ");
                            g.Nom = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Description : ");
                            g.Description = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Licence : ");
                            g.Licence = Console.ReadLine();
                            Console.WriteLine("");

                            Console.WriteLine("Taper le numéro du type de votre goodies :");
                            Console.WriteLine("1. Inconnue");
                            Console.WriteLine("2. Figurine");
                            Console.WriteLine("3. Vetement");
                            Console.WriteLine("4. Accessoire");
                            Console.WriteLine("5. Bijoux");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1: { }; break;
                                case 2: { g.Type = Types.Figurine; }; break;
                                case 3: { g.Type = Types.Vetement; }; break;
                                case 4: { g.Type = Types.Accessoire; }; break;
                                case 5: { g.Type = Types.Bijoux; }; break;
                            }
                            Console.WriteLine("");

                            Console.WriteLine("Prix : ");
                            g.Prix = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                            Console.Clear();

                            catalogue.AjoutGoodies(g);
                        }
                    
                    };break;

                    /*
                     * Retirer
                     */

                    case 2: {
                        Console.WriteLine("1. Retirer_Jeu");
                        Console.WriteLine("2. Retirer_Goodies");
                        Console.WriteLine("3. Retour");

                        String resa = Console.ReadLine();
                        int choixa = int.Parse(resa);

                        if(choixa == 1)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Donnez le nom du jeu que vous voulez supprimer :");
                            catalogue.DelJeu(Console.ReadLine());
                        }
                        else if(choixa == 2)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Donnez le nom du goodies que vous voulez supprimer :");
                            catalogue.DelGoodies(Console.ReadLine());
                        }
                        Console.Clear();
                    };break;

                    /*
                     * Recherche
                     */

                    case 3: {
                        Console.WriteLine("");
                        Console.WriteLine("1. Afficher le catalogue");
                        Console.WriteLine("2. Recherche de jeu par nom");
                        Console.WriteLine("3. Recherche de jeu par genre");
                        Console.WriteLine("4. Recherche de goodies par nom");
                        Console.WriteLine("5. Retour");

                        String resa = Console.ReadLine();
                        int choixa = int.Parse(resa);

                        switch(choixa)
                        {
                            case 1:
                                {
                                    Console.WriteLine("");
                                    catalogue.affiche_catalogue();
                                };break;
                            case 2:
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Entrer le nom du jeu que vous voulez rechercher : ");
                                    LesJeux ls = catalogue.GetJeuNom(Console.ReadLine());
                                    if (ls.Taille > 0)
                                        Console.WriteLine(ls.ToString());
                                    else
                                    {
                                        Console.WriteLine("Le jeu demandé n'est pas dans le catalogue");
                                    }
                                };break;
                                
                            case 3:
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Taper le numéro du genre :");
                                    Console.WriteLine("1. Aucun");
                                    Console.WriteLine("2. Plateforme");
                                    Console.WriteLine("3. Action_RPG");
                                    Console.WriteLine("4. Action_Aventure");
                                    Console.WriteLine("5. Football");
                                    Console.WriteLine("6. Course_Auto");

                                    String resb = Console.ReadLine();
                                    int choixb = int.Parse(resb);
                                    LesJeux ls = new LesJeux();
                                    switch (choixb)
                                    {
                                        case 1: { ls = catalogue.GetJeuGenre(Genres.Aucun); };break;
                                        case 2: { ls = catalogue.GetJeuGenre(Genres.Plateforme); }; break;
                                        case 3: { ls = catalogue.GetJeuGenre(Genres.Action_RPG); }; break;
                                        case 4: { ls = catalogue.GetJeuGenre(Genres.Action_Aventure); }; break;
                                        case 5: { ls = catalogue.GetJeuGenre(Genres.Football); }; break;
                                        case 6: { ls = catalogue.GetJeuGenre(Genres.Course_Auto); }; break;
                                    }
                                   
                                    if (ls.Taille > 0)
                                    {
                                        Console.WriteLine(ls.ToString());
                                    }
                                    else
                                    {
                                        Console.WriteLine("il n'y a pas de jeu du genre demandé");
                                    }

                                };break;

                            case 4:
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Entrer le nom du goodies que vous voulez rechercher : ");
                                    LesGoodies lsg = catalogue.GetGoodiesNom(Console.ReadLine());
                                    if (lsg.Taille > 0)
                                        Console.WriteLine(lsg.ToString());
                                    else
                                        Console.WriteLine("Le goodies demandé n'est pas dans le catalogue");
                                };break;
                                
                        }


                    };break;
                    case 4: {quit = choix;};break;
                }
        }
    
    }
}