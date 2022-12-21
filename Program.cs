using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter The First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Prime Numbers Between {0} and {1}", num1, num2);

            if (num1 <= 2)                                       // all prime numbers is odd except '2'   
                Console.WriteLine(2);                           // So this command to begin with odd number
            if (num1 % 2 == 0)                               // and print '2' if the begin <= 2
                num1++;


            while (num1 <= num2)
            {

                if (prime1(num1))
                {
                    Console.WriteLine(num1);
                }
                num1 += 2;
            }
            Console.ReadKey();
        }
        static bool prime1(int x)     // method to determine if the input "x" is prime
        {
            //  assume that x is prime
            bool Is_Prime = true;
            if (x != 1 && x % 2 != 0)                               // all prime numbers is odd                      
                for (int i = 3; i <= Math.Sqrt(x); i += 2)        // and x is prime when x hasn't a prime divisor <= √x
                {
                    if (x % i == 0)
                    {
                        Is_Prime = false;
                        break;
                    }
                }
            else Is_Prime = false;
            return Is_Prime;
        }
    }
}
