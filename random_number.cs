using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._19_lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Average:");

            //int sum=0;
            int x = 0;
            int sum = 0;
            int i=1;
            while (sum >=0) {
               
               sum = Convert.ToInt32(Console.ReadLine());
                x = x + sum;
                i++;

            }
            int avr = x / i;
            Console.WriteLine("The Average is: "+avr);

    

            int a; int b; int c;

            do {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------");
            }

            while (a*b != c);

            Console.WriteLine(a+"*"+b+"="+c);
            */



            Random eng = new Random();
            int nrnd = eng.Next(100) + 1;

            int inpt;

            do
            {
                inpt = Convert.ToInt32(Console.ReadLine());
                if (inpt > nrnd) { Console.WriteLine($"Your guess is less than {nrnd}, please try again "); }
                if (inpt < nrnd) { Console.WriteLine($"Your guess is more than {nrnd}, please try again "); }


            }

            while (inpt != nrnd);

            Console.WriteLine();



        }
    }
}
