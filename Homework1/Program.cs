
namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | even                                 |
          * |--------|--------------------------------------|
          * |  2     | odd                                  |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("even");
                else
                    Console.WriteLine("odd");
            }
            else Console.WriteLine("the value should be greater then zero");
        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            Console.WriteLine((number % 4 == 0) ? "The number divide to 4" : "The number doesn't divide to 4");
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day.ToLower()) // instead of doing checkings for all cases, just make the input to lower case in switch head.
                //Thus, even MoNdAy would work out in the calling of the function. 
            {
                case "monday": Console.WriteLine("1");
                    break;
                case "tuesday": Console.WriteLine("2");
                    break;
                case "wednesday": Console.WriteLine("3");
                    break;
                case "thursday": Console.WriteLine("4");
                    break;
                case "friday": Console.WriteLine("5");
                    break;
                case "saturday": Console.WriteLine("6");
                    break;
                case "sunday": Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Wrong value! Please give a day of a week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            // First variant.
            /* switch (character.ToString().ToLower()) 
             {
                 case "a":
                 case "e":
                 case "i":
                 case "o":
                 case "u":
                     Console.WriteLine(character + " is a vowel");
                     break;
                 case "b":
                 case "c":
                 case "d":
                 case "f":
                 case "g":
                 case "j":
                 case "k":
                 case "l":
                 case "m":
                 case "n":
                 case "p":
                 case "q":
                 case "s":
                 case "t":
                 case "v":
                 case "x":
                 case "z":
                 case "h":
                 case "r":
                 case "w":
                 case "y":
                     Console.WriteLine(character + " is a consonant");
                     break;
                 default:
                     Console.WriteLine(character + " is not a letter");
                     break;
             }*/

            // Second variant.
            if (Char.IsLetter(character))
            {
                if (character.ToString().ToLower() == 'a'.ToString() ||
                character.ToString().ToLower() == 'e'.ToString() ||
                character.ToString().ToLower() == 'i'.ToString() ||
                character.ToString().ToLower() == 'o'.ToString() ||
                character.ToString().ToLower() == 'u'.ToString()
               ) Console.WriteLine(character + " is a vowel");
                else Console.WriteLine(character + " is a consonant");
            }
            else Console.WriteLine(character + " is not a letter");
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');
            homework.CheckLetterIfVowel('5');

        }
    }
}
