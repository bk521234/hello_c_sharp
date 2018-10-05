#define PI

#define DEBUG
#define VC_10
using System;

/* preprocessor directives are not statements so they do not end with a ;
    preprocessor directives are one to a line
     */

namespace PreprocessorDAppl{
    class Program{
        static void Main(string[] args){
            #if (PI)
                Console.WriteLine("PI is defined");
            #else
                Console.WriteLine("PI is not defined");
            #endif

            /* practicing conditional directives */
            #if (DEBUG && !VC_10)
                Console.WriteLine("DEBUG is defines");
            #elif (!DEBUG && VC_10)
                Console.WriteLine("VC_10 is defines");
            #elif (DEBUG && VC_10)
                Console.WriteLine("DEBUG and VC_10 are defined");
            #else 
                Console.WriteLine("DEBUG and VC_10 are not defined");
            Console.ReadKey();
        }   
    }
}

