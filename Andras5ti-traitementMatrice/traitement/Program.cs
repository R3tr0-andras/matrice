using System;

namespace traitement
{
    class Program
    {
        static void Main(string[] args)
        {
            traitement outil = new traitement();
            byte recom = 0;
            do
            {
                Console.Clear();
                // variable
                int dim1, dim2, dim3, dim4;
                int met = 0;

                Console.Write("Entrez le nombre de lignes de la matrice 1 : ");
                dim1 = int.Parse(Console.ReadLine());

                Console.Write("Entrez le nombre de colonnes de la matrice 1 : ");
                dim2 = int.Parse(Console.ReadLine());

                Console.Write("Entrez le nombre de lignes de la matrice 2 : ");
                dim3 = int.Parse(Console.ReadLine());

                Console.Write("Entrez le nombre de colonnes de la matrice 2 : ");
                dim4 = int.Parse(Console.ReadLine());

                met = int.Parse(Console.ReadLine());



                if (met == 1) //addition
                {
                    traitement.Genere(dim1, dim2, out int[,] matrice1);
                    traitement.Genere2(dim3, dim4, out int[,] matrice2);




                }
                else if (met == 2)// concaténation 
                {
                    traitement.conca();
                }
                else if (met == 3)// multiplication
                {
                    traitement.multi();
                }
                else
                {
                    Console.WriteLine("vous n'avez pas entre un bon chiffre : fermeture du programme");
                }
            }
            while (recom == 0);
            Console.WriteLine("Au revoir ;)");
        }
    }
}
