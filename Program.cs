using System;
using System.Globalization;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge 1 */
            string text = "this is a text";
            string newText = toTitleCase(text);
            Console.WriteLine(newText); // expect to see "This Is A Text"

            /* Challenge 2 */
            int[,] arrayA = { { 3, 5, 4, 6 }, { 3, 7, 8, 3 } };
            int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
            int[,] result = matrixMultiply(arrayA, arrayB);
            Console.WriteLine(result); //share your findings to Slack
        }
        static string toTitleCase(string input)
        {
            var titleCaseString = "";
            string[] newArray = input.Split(" ");
            foreach (string i in newArray)
            {
                titleCaseString += char.ToUpper(i[0]) + i.Substring(1) + " ";
            }
            return titleCaseString.Trim();
        }

        static int[,] matrixMultiply(int[,] array1, int[,] array2)
        {
            int m = 2, n = 4, p = 4, q = 4, i, j;

            // Console.WriteLine("Matrix 1:");
            // for (i = 0; i < m; i++)
            // {
            //     for (j = 0; j < n; j++)
            //     {
            //         Console.Write(array1[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // Console.WriteLine("Matrix b:");
            // for (i = 0; i < p; i++)
            // {
            //     for (j = 0; j < q; j++)
            //     {
            //         Console.Write(array2[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            if (n != p)
            {
                throw new Exception("Error");
            }
            else
            {
                int[,] c = new int[m, q];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            c[i, j] += array1[i, k] * array2[k, j];
                        }
                    }
                }
                Console.WriteLine("The product of the two matrices is :");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        return (c[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
