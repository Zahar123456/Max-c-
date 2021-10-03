using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Enemy> enemies = new List<Enemy>();
          Berserk bers = new Berserk();
          Soldier sold  = new Soldier();
        
          enemies.Add(bers);
          enemies.Add(sold);

          for(int i = 0; i < enemies.Count; i++)
          {
            enemies[i].Move();
          }
        }
        
        static int NumberPow(int pow, int number)
        {   
            int result = 1;
            for(int n = 0; n < pow; n++)
            {
                result = result * number;
            }
            return result;
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
       
    class Enemy
    { 
        public int damage;
        public string name;
        public int health;

        public virtual void Move()
        {
            Console.WriteLine("Enemy move");

        }

    }   
    class Berserk : Enemy
    {
        override public void Move()
        {
            base.Move();
            Console.WriteLine("Berserk bleeding");
        }

    } 
    
    class Soldier : Enemy
    {
        override public void Move(){
            Console.WriteLine("Soldiers move");
        }
    }                

}