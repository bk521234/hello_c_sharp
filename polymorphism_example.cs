using System;

namespace PolymorphismApplication{
    class PrintData{
        void print(int i){
            Console.WriteLine("Printing int: {0}", i);
        }
        void print(double f){
            Console.WriteLine("Printing float: {0}", f);
        }
        void print(string s){
            Console.WriteLine("Printing string: {0}", s);
        }

    }
    static void Main(string[] args){
        PrintData p = new PrintData();
        // call print for different data types
        p.print(4);
        p.print(567.98);
        p.print("Hello from C#");
        
        Console.ReadKey;
    }
}