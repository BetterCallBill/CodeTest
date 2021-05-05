using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTest
{
    // BinaryGap
    public class CyclicRotation
    {
        static void Main()
        {
            int[] x = { };
            int k = 1;

            var result = solution1(x, k);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] solution1(int[] A, int K)
        {
            if (K == A.Length || A.Length == 0)
            {
                return A;
            }

            int[] currentArray = A;

            for (int i = 0; i < K; i++)
            {
                int[] newArray = new int[currentArray.Length];
                newArray[0] = currentArray.Last();
                Array.Copy(currentArray, 0, newArray, 1, currentArray.Length - 1);
                currentArray = newArray;
            }

            return currentArray;
        }

        // from Github
        public static int[] solution2(int[] A, int K)
        {
            if (K == A.Length || A.Length == 0)
            {
                return A;
            }

            for (int i = 0; i < K; i++)
            {
                int last = A[A.Length - 1];
                for (int j = A.Length - 1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }
                A[0] = last;
            }

            return A;
        }
    }
}
