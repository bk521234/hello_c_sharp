using System;

namespace Loops{
    class Program {
        static void Main(string[] args){
            /* local variable definition */
            int a = 10;

            /* while loop execution */
            while (a < 20){
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            Console.ReadLine();

            /* for loop execution */            
            for (int var = 10; var < 20; var = var + 1){
                Console.WriteLine("calue of var is : {0}", var);
            }
            Console.ReadLine();

            /* do while loop */
            int a = 35;

            do{
                Console.WriteLine("do loop, value of a : {0}", a);
                a = a +1;
            }
            while (a < 45);
            Console.Readline();

            /* nested for loop */
            int i, j;

            for (i=2, i<100, i++){
                for (j=2; j <= (i/j); j++){
                    if ((i%j) == 0) break; // if factor found, not prime
                    if (j > (i/j)) Console.WriteLine("{0} is prime", i);
                }
            Console.Readline();
            }
            /* continue statement */
            int t;

            for (t =90; t<=100; t++){
                if ((t % 2) == 0){
                    continue;
                }
                Console.WriteLine("Value in continue for loop : {0}", t);
            }
            Console.Readline();

            Console.WriteLine("\n\nProgram Complete.");
            Console.Readline();
        }
    }
}