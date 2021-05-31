using System;

namespace passwordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arraySymbols = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "n", "m", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z"};
            string[] arrayNumbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] arraySpecialSymbols = { "!", "@", "#", "$", "&", "?" };
            object[] additionalParameters = { arraySymbols, arrayNumbers, arraySpecialSymbols };
            string generatedPassword = "";


            int i;
            Console.Write("Please enter the number of symbols in your password: ");
            int passwordDifficulty = Convert.ToInt32(Console.ReadLine());

            for(i = 0; i <= passwordDifficulty; i++)
            {
                Random rand = new Random();
                int symbolType = rand.Next(additionalParameters.Length);

                if (symbolType == 1)
                {
                    int index = rand.Next(arraySymbols.Length);
                    generatedPassword = generatedPassword + arraySymbols[index];
                }

                else if (symbolType == 2)
                {
                    int index = rand.Next(arrayNumbers.Length);
                    generatedPassword = generatedPassword + arrayNumbers[index];
                }

                else {

                    int index = rand.Next(arraySpecialSymbols.Length);
                    generatedPassword = generatedPassword + arraySpecialSymbols[index];
                }


            }
            Console.WriteLine(generatedPassword);
        }
    }
}
