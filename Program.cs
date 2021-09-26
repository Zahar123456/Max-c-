using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string : ");
            string userInput = Console.ReadLine();
            RemoveLetters(userInput);
          
        }

        static void RemoveLetters(string inputString)
        {
            List<String> wrongLetters = new List<String>();
            wrongLetters.Add("o");
            wrongLetters.Add("i");
            wrongLetters.Add("u");
            wrongLetters.Add("a");
            wrongLetters.Add("e");
            
            wrongLetters.Add("O");
            wrongLetters.Add("I");
            wrongLetters.Add("U");
            wrongLetters.Add("A");
            wrongLetters.Add("E");

            string result = "";
            for(int i = 0; i < inputString.Length; i++ )
            {
                if (!wrongLetters.Contains(inputString[i].ToString()))
                {
                    result = result + inputString[i];
                }
            }
            Console.WriteLine("Result:" + result);
        } 
        
            
       
                           
        
    }

}