using System;

namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter text with at least 5 words");
            string text = Console.ReadLine();
            TaskOne(text);
            TaskTwo(text);
            TaskThree(text);
            Console.ReadLine();
        }

        public static void TaskOne(string text)
        {
            string newText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    newText += text[i];
                }
            }

            string[] words = newText.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    char[] array = words[i].ToCharArray();
                    Array.Reverse(array);
                    words[i] = new string(array);
                }
            }

            string result = string.Join(" ", words);
            Console.WriteLine("Result of task one");
            Console.WriteLine(result);
        }

        public static void TaskTwo(string text)
        {
            string[] words = text.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = FirstLetterToUpper(words[i].ToLower());
            }

            string result = string.Join(" ", words);
            Console.WriteLine("Task two");
            Console.WriteLine(result);
        }

        public static void TaskThree(string text)
        {
            text.ToLower();
            string[] words = text.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
              if (words[i].StartsWith("p"))
                {
                    words[i] = "S" + words[i].Substring(1);
                }

              if (words[i].EndsWith("n"))
                {
                    words[i] = words[i].Remove(words[i].Length - 1, 1) + "O";
                }
            }

            string result = string.Join(" ", words);
            Console.WriteLine("Task three");
            Console.WriteLine(result);
        }

        public static string FirstLetterToUpper(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
