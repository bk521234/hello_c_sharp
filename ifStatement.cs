using System;

namespace DecisionMaking{
    class Program{
        static void Main(string[] arg){
            /* local variable definition */
            int a = 10;

            /* check the boolean condition using if statement */
            if (a < 23){
                /* if condition is tru then print the following */
                Console.WriteLine("a is less than 23");
            } else if (a== 23){
                Console.WriteLine("a is equal to 23!!!");
            } else {
            /* statement (s) that will execute if the boolean expression is false */
            Console.WriteLine("Variable a is not less than 23.");
            }
            Console.WriteLine("calue of a is : {0}", a);
            Console.ReadLine();
        } 
    }
}