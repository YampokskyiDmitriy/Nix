using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] arrN = new int[20];
            int count = 0;
            Console.WriteLine("arrN");
            for(int i = 0; i < arrN.Length; i++)
            {
                arrN[i] = random.Next(-200, 200);

                Console.WriteLine($"{i}:{arrN[i]}, ");

                if( arrN[i] > -101 && arrN[i] < 100)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numbers in range from -100 to 100: {count}");


            int[] arrA = new int[20];
            int[] arrB = new int[20];
            int bCounter = 0;
            Console.WriteLine("arrA");
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = random.Next(2000);

                Console.WriteLine($"{i}:{arrA[i]}, ");

                if (arrA[i] <= 888)
                {
                    arrB[bCounter] = arrA[i];
                    bCounter++;
                }
            }

            Console.WriteLine("arrB");
            for (int i = 0; i < arrB.Length; i++)
            {
                Console.WriteLine($"{i}:{arrB[i]}, ");
            }

            Console.ReadLine();
        }
    }
}
