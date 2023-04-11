using System;
using System.Collections.Generic;
using System.Text;

namespace traitement
{
    public struct traitement
    {
        public void afficher(int rows1, int cols1, int rows2, int cols2, out int[,] matrix1, int[,] matrix2)
        {
            // Afficher les matrices générées
            Console.WriteLine("Première matrice :");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Deuxième matrice :");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            // Vérifier que les deux matrices ont la même dimension
            if (rows1 != rows2 || cols1 != cols2)
            {
                throw new ArgumentException("Les deux matrices doivent avoir la même dimension.");
            }

            // Créer la matrice résultat
            int[,] resultMatrix = new int[rows1, cols1];

            // Additionner les éléments de chaque matrice pour créer la matrice résultat
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Retourner la matrice résultat
            return resultMatrix;
        }

        public int[,] ConcatenateMatrices(int[,] matrix1, int[,] matrix2)
        {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Vérifier que les deux matrices ont le même nombre de lignes
        if (rows1 != rows2)
        {
            throw new ArgumentException("Les deux matrices doivent avoir le même nombre de lignes.");
        }

        // Créer la matrice résultat
        int[,] resultMatrix = new int[rows1, cols1 + cols2];

        // Copier les éléments de la première matrice dans la matrice résultat
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                resultMatrix[i, j] = matrix1[i, j];
            }
        }

        // Copier les éléments de la deuxième matrice dans la matrice résultat
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                resultMatrix[i, j + cols1] = matrix2[i, j];
            }
        }

        // Retourner la matrice résultat
        return resultMatrix;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            // Vérifier que le nombre de colonnes de la première matrice est égal au nombre de lignes de la deuxième matrice
            if (cols1 != rows2)
            {
                throw new ArgumentException("Le nombre de colonnes de la première matrice doit être égal au nombre de lignes de la deuxième matrice.");
            }

            // Créer la matrice résultat
            int[,] resultMatrix = new int[rows1, cols2];

            // Multiplier les matrices pour créer la matrice résultat
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Retourner la matrice résultat
            return resultMatrix;
        }
    }
}