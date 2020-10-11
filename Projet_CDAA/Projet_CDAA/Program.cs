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


            switch(choix)
                {

                    /*
                     * Ajout
                     */

                    case 1: {
                        Console.Clear();
                        Console.WriteLine("1. Ajouter_Jeu");
                        Console.WriteLine("2. Ajouter_Console"); 
                        Console.WriteLine("3. Retour");
                        String resa = Console.ReadLine();
                        int choixa = int.Parse(resa);
                        Console.Clear();

                            /*
                             * Ajout d'un jeu 
                             */

                        if(choixa == 1)
                        {
                            Jeu j = new Jeu();
                                
                            Console.WriteLine("Nom du jeu : ");
                            j.Nom = Console.ReadLine();
                            Console.Clear();
                                
                            Console.WriteLine("Description : ");
                            j.Description = Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine("Plateforme : ");
                            j.Plateforme = Console.ReadLine();
                            Console.Clear();

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
                            Console.Clear();
                                
                            Console.WriteLine("Editeur : ");
                            j.Editeur = Console.ReadLine();
                            Console.Clear();
                                
                            Console.WriteLine("Prix : ");
                            j.Prix = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                            Console.Clear();

                            String d = "01/01/1900"; 
                            Console.WriteLine("Entré la date en suivant le Model dd/MM/yyyy : ");
                            d = Console.ReadLine();
                            j.Date = DateTime.ParseExact(d,"dd/MM/yyyy",null);
                            Console.Clear();

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
                         * Ajout objet du catalogue
                         */

                        if(choixa == 2)
                        {

                        }
                    
                    };break;

                    /*
                     * Retirer
                     */

                    case 2: {
                        Console.Clear();
                        Console.WriteLine("1. Retirer_Jeu");
                        Console.WriteLine("2. Retirer_Console");
                        Console.WriteLine("3. Retour");

                        String resa = Console.ReadLine();
                        int choixa = int.Parse(resa);

                        if(choixa == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Donnez le nom du jeu que vous voulez supprimer :");
                            catalogue.DelJeu(Console.ReadLine());
                        }
                        else if(choixa == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Donnez le nom de la console que vous voulez supprimer :");
                            catalogue.DelConsole(Console.ReadLine());
                        }
                    };break;

                    /*
                     * Recherche
                     */

                    case 3: {
                        Console.Clear();
                        Console.WriteLine("1. Afficher le catalogue");
                        Console.WriteLine("2. Recherche de jeu par nom");
                        Console.WriteLine("3. Recherche de jeu par genre");
                        Console.WriteLine("4. Recherche de console par nom");
                        Console.WriteLine("5. Retour");

                        String resa = Console.ReadLine();
                        int choixa = int.Parse(resa);

                        switch(choixa)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    catalogue.affiche_catalogue();
                                };break;
                            case 2:
                                {
                                    Console.Clear();
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
                                    Console.Clear();
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
                                
                        }


                    };break;
                    case 4: {quit = choix;};break;
                }
        }
    
    }
}