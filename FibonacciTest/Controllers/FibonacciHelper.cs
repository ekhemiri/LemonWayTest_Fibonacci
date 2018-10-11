using System;

namespace FibonacciTest.Controllers
{
    public class FibonacciHelper
    {
        private const int VALEUR_CENT = 100;
        private const int VALEUR_UN = 1;
        private const int VALEUR_DEUX = 2;
        private const int VALEUR_ERREUR = -1;

        /// <summary>
        /// Calcul de la suite de fibonacci.
        /// </summary>
        /// <param name="n">La valeur du paramètre.</param>
        /// <returns>La valeur de la suite de fibonacci.</returns>
        /// <exception cref="NullReferenceException">Si le paramètre d'entrée est null.</exception>
        public int Fibonacci(int n)
        {
            try
            {
                if (VALEUR_UN > n || VALEUR_CENT < n)
                {
                    return VALEUR_ERREUR;
                }
                else if (VALEUR_UN.Equals(n))
                {
                    return VALEUR_UN;
                }
                else
                {
                    int[] suiteFibonacci = new int[100];
                    suiteFibonacci[0] = 0;
                    suiteFibonacci[1] = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        suiteFibonacci[i] = suiteFibonacci[i - 1] 
                            + suiteFibonacci[i - 2];
                    }
                    return suiteFibonacci[n];
                }
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }
    }
}