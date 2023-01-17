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
            int m = array1.GetLength(0), n = array1.GetLength(1), p = array2.GetLength(0), q = array2.GetLength(1), i, j;

            if (n != p) //to multiply the matrics the number of column in array1 should be equal to number of rows in array2
            {
                throw new Exception("Error");
            }
            else
            {
                int[,] finalResult = new int[m, q]; // the result is displayed in 2 rows, 2 columns
                for (i = 0; i < m; i++) // loop 2 times for array1[0] and array1[1]
                {
                    for (j = 0; j < q; j++) // loop 2 times to find result of array1[0] with array2's first colum, then array1[1] vs
                    //array2's second column. And same process with array1[1]
                    {
                        var c = 0;
                        for (int k = 0; k < n; k++)
                        {
                            c += array1[i, k] * array2[k, j];

                        }
                        finalResult[i, j] = c;
                        System.Console.WriteLine($"c value ---- {c}");
                    }
                }
                return finalResult;

            }
        }

    }
}
