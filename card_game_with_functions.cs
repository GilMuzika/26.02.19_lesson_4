using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _19._02._19_lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Random engine = new Random();

            // get new card
            int compscore = 0;
            int myscore = 0;

            while (compscore != 5 && myscore != 5)
            {
                int rndmycard = engine.Next(2, 15);
               // get new card
                int rndcomputercard = engine.Next(2, 15);
               // get new card

                PrintWhoWon(BodyOfTheGame(rndmycard), BodyOfTheGame(rndcomputercard), ref myscore, ref compscore);
            }

          
        }



        static void PrintWhoWon(int mycard, int computercard, ref int myscore, ref int compscore)
        {
            if (mycard > computercard)
            {
                myscore++; Console.WriteLine($"I won this round!!!! My score is {myscore}");
            }
            else if (computercard > mycard)
            {
                compscore++; Console.WriteLine($"Computer won ... booooo. Computer's score is {compscore}");
            }
            else
            {
                Console.WriteLine("Tie!");
            }


        }


        static int BodyOfTheGame(int card)
        {

            // print card

            switch (card)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine(card); 
                    break;
                case 11:
                    Console.WriteLine("J"); 
                    break;
                case 12:
                    Console.WriteLine("Q"); 
                    break;
                case 13:
                    Console.WriteLine("K"); 
                    break;
                case 14:
                    Console.WriteLine("A"); 
                    break;
                default:
                    Console.WriteLine("Bad card!!!!!!!!!!!"); 
                    break;
            }
            
            Thread.Sleep(500);
            return card;

        }


    }
}
