using System;

namespace ValidationRobusteseMotDePasse
{
    class Program
    {
        public static void Main(string[] args)
        {

            // saisie du mot de passe
            Console.WriteLine("Saisissez un mot de passe à 4 caractères");
            String mdp = Console.ReadLine();

            // booléen qui indique si le mdp est valide ou pas
            Boolean valide = false;

            // vérification de la longueur
            int longueur = mdp.Length;
            Console.WriteLine("Longueur : " + longueur);

            if (longueur >= 4)
            {
                valide = true;
            }
            else
            {
                Console.WriteLine("Longueur : " + longueur);
                Console.WriteLine("Longueur trop courte");

                // Console app
                System.Environment.Exit(1);
            }

            // récupération des lettres du mot de passe
            // carac1 est le 1èr caractère du mdp
            char carac1 = mdp[0];
            // carac2 est le 2ème
            char carac2 = mdp[1];
            // etc.
            char carac3 = mdp[2];
            char carac4 = mdp[3];


            // affichage des caractères pour vérifier
            Console.WriteLine(carac1);
            Console.WriteLine(carac2);
            Console.WriteLine(carac3);
            Console.WriteLine(carac4);



            // vérification du 1er caractère
            int codeASCII1 = (int)carac1;
            Console.WriteLine("le 1er code est " + codeASCII1);

            Boolean valideCar1 = false;

            // si le code ASCII est compris entre 65 et 90
            if (codeASCII1 >= 65 && codeASCII1 <= 90)
            {
                valideCar1 = true;
            }

            int codeASCII4 = (int)carac4;
            Boolean valideCar4 = false;

            if (codeASCII4 >= 48 && codeASCII4 <= 57)
            {
                valideCar4 = true;
            }

            // caractère spécial 33-47 91-96  123-126


            // test si le booléen est vrai ou faux
            if (valide == true && valideCar1 == true && valideCar4 == true)
            {
                // affichage : mdp valide
                Console.WriteLine("le mdp est valide");
            }
            else
            {
                // affichage : mdp pas valide
                Console.WriteLine("le mdp n'est pas valide");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}