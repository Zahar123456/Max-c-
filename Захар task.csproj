using System;

namespace Zahartask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        static void Task1()
        {
            int[] array = new int[] { 1, 4, -2, 5, 13, 7, 5, 9, 5, 12, 3 };
            Console.WriteLine("Enter number :");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers: ");
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < number)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
        
        static void Task2()
        {
            Console.WriteLine("Введите палиндром");
            string word = Console.ReadLine();
            word.Replace(" ", "");
            int j = word.Length;
            int error = 0;
            for(int i = 0; i < word.Length; i++)
            {
                j--;
                if (word[i] != word[j])
                {
                    error = 1;
                }
            }
            if(error == 0)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка  не является палиндромом");
            }

        }
    
    }
}
