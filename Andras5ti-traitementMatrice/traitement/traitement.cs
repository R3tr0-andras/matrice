using System;
using System.Collections.Generic;
using System.Text;

namespace traitement
{
    public struct traitement
    {
        public void Genere(int dim2, int dim1, out int[,] matrice1)
        {
            matrice1 = new int[dim1, dim2];  // déclare la matrice de dimensions saisies par l'utilisateur
            Random rnd = new Random();  // crée un objet Random pour générer des valeurs aléatoires

            for (int i = 0; i < dim1; i++)  // boucle sur les lignes de la matrice
            {
                for (int j = 0; j < dim2; j++)  // boucle sur les colonnes de la matrice
                {
                    matrice1[i, j] = rnd.Next(21);  // assigne une valeur aléatoire entre 0 et 20
                }
            }

            // affiche la matrice remplie (optionnel)
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    Console.Write(matrice1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Genere2(int dim4, int dim3, out int[,] matrice2)
        {
            matrice2 = new int[dim3, dim4];  // déclare la matrice de dimensions saisies par l'utilisateur
            Random rnd = new Random();  // crée un objet Random pour générer des valeurs aléatoires

            for (int i = 0; i < dim3; i++)  // boucle sur les lignes de la matrice
            {
                for (int j = 0; j < dim4; j++)  // boucle sur les colonnes de la matrice
                {
                    matrice2[i, j] = rnd.Next(21);  // assigne une valeur aléatoire entre 0 et 20
                }
            }

            // affiche la matrice remplie (optionnel)
            for (int i = 0; i < dim3; i++)
            {
                for (int j = 0; j < dim4; j++)
                {
                    Console.Write(matrice2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void add(int [,] matrice1, int [,] matrice2, out bool succes, int [,] matriceResultat)
        {
            int nbLignes = matrice1.GetLength(0);
            int nbColonnes = matrice1.GetLength(1);

            succes = true;
            matriceResultat = new int[nbLignes, nbColonnes];

            // déroulement
            if (nbLignes != matrice2.GetLength(0) || nbColonnes != matrice2.GetLength(1))
            {
                succes = false;
            }
            else
            {
                for (int i = 0; i < nbLignes; i++)
                {
                    for (int j = 0; j < nbColonnes; j++)
                    {
                        matriceResultat[i, j] = matrice1[i, j] + matrice2[i, j];
                    }
                }
            }

            // afichage
            if (succes)
            {
                Console.WriteLine("Addition des matrices réussie, le résultat est :");
                for (int i = 0; i < nbLignes; i++)
                {
                    for (int j = 0; j < nbColonnes; j++)
                    {
                        Console.Write(matriceResultat[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Impossible d'additionner les matrices.");
            }

            Console.ReadKey();
        }
        public void conca(int [,] matrice1, int [,] matrice2, out string stringTab)
        {
            string stringTab = "";
            
            for (lignes = 0; ligne < stringTab.Getlength(0) - 1; ligne++)
            {
                for (colonne = 0; colonne < stringTab.Getlength(0) - 1; colonne++)
                {
                    stringTab += stringTab[ligne, colonne] + "|";
                }
                stringTab[ligne, colonne] += "\n";
            }
        }
        public static bool MultiplyMatrices(int[,] matrice1, int[,] matrice2, out int[,] matriceResultat)
        {
            int nbLignes1 = matrice1.GetLength(0);
            int nbColonnes1 = matrice1.GetLength(1);
            int nbLignes2 = matrice2.GetLength(0);
            int nbColonnes2 = matrice2.GetLength(1);
            matriceResultat = null;
            if (nbColonnes1 != nbLignes2)
            {
                return false;
            }
            else
            {
                matriceResultat = new int[nbLignes1, nbColonnes2];
                for (int i = 0; i < nbLignes1; i++)
                {
                    for (int j = 0; j < nbColonnes2; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < nbColonnes1; k++)
                        {
                            sum += matrice1[i, k] * matrice2[k, j];
                        }
                        matriceResultat[i, j] = sum;
                    }
                }
                return true;
            }

        }
    }
}