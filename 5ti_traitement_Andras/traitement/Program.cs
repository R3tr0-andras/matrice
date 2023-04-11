using System;

namespace traitement
{
    class Program
    {
        static void Main(string[] args)
        {
            double nombre, resultat;
            int choix;

            do
            {
                Console.Clear();
                // Demander les dimensions des matrices
                Console.WriteLine("Entrez le nombre de lignes de la première matrice :");
                int rows1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le nombre de colonnes de la première matrice :");
                int cols1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le nombre de lignes de la deuxième matrice :");
                int rows2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le nombre de colonnes de la deuxième matrice :");
                int cols2 = int.Parse(Console.ReadLine());

                // Générer les nombres aléatoires pour les matrices
                Random rand = new Random();
                int[,] matrix1 = new int[rows1, cols1];
                int[,] matrix2 = new int[rows2, cols2];
                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols1; j++)
                    {
                        matrix1[i, j] = rand.Next(10);
                    }
                }
                for (int i = 0; i < rows2; i++)
                {
                    for (int j = 0; j < cols2; j++)
                    {
                        matrix2[i, j] = rand.Next(10);
                    }
                }

                Console.WriteLine("| Choisissez une méthode de traitement :");
                Console.WriteLine("| 1. Concaténation");
                Console.WriteLine("| 2. Addition");
                Console.WriteLine("| 3. multiplication");
                choix = Convert.ToInt32(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        traitement.afficher();
                        traitement.ConcatenateMatrices();
                        break;
                    case 2:
                        Console.Clear();
                        traitement.afficher();
                        traitement.AddMatrices();
                        break;
                    case 3:
                        Console.Clear();
                        traitement.afficher();
                        traitement.MultiplyMatrices();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Erreur : La réponse est 42 !");
                        break;
                }

                Console.Write("Voulez-vous recommencer ? (O/N) : ");
            } while (Console.ReadLine().ToUpper() == "O");

            Console.WriteLine("Au revoir !");
            Console.ReadKey();
        }
    }
}
