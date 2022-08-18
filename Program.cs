using System;
using System.Linq;

namespace blackjack
{
    internal class Program
    {
        static int hite()
        {
            Random random = new Random();
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int ncard=random.Next(cards.Length);
            return ncard;
        }
        
        static void Welcome(int comp,int user)
        {
            
            Console.Write("Your card is " + user);
            if (user==0)
            {
                user+=1;
            }
            Console.Write(", Do you want to hit?");
            string hit=Console.ReadLine();
            hit=hit.Trim().ToLower();
            if (hit.Contains('n'))
            {
                Console.WriteLine(user);
                if (user <comp&&user<22)
                {
                    Console.WriteLine(comp);
                    Console.WriteLine("You lose.");
                    Main(null);
                }
                else if (user >comp&& user<22)
                {
                    Console.WriteLine(comp);
                    Console.WriteLine("You win");
                    Main(null);
                }
            }
            else if (hit.Contains('y'))
            {
                int ncard=hite();
                user += ncard;
                if (user >21)
                {
                    Console.WriteLine("You lose");
                    Main(null);
                }
                else
                {
                    Console.WriteLine(user);
                    Welcome(comp,user);
                }

            }
            else
            {
                Console.WriteLine("Please put Yes or No.");
                Welcome(comp,user);
            }


            Console.ReadLine();
        }
        static void Card()
        {
            Random random = new Random();

            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] special = {16,17,18,19,20,21 };
            int comp = random.Next(16,21);
            int user = random.Next(cards.Length);
            if (user ==0)
            {
                user=1;
            }
            Welcome(comp,user);  
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Card();
        }
    }
}
