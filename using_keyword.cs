using System;
using first_namespace;
using second_namespace;

namespace first_namespace{
    class first_namespace_c1{
        public void func(){
            Console.WriteLine("Inside first_namespace");
        }
    }
}
namespace second_namespace{
    class second_namespace_c1{
        public void func(){
            Console.WriteLine("Inside second_namespace");
        }
    }
    class TestClass{
        static void Main(string[] args){
            first_namespace_c1 fc = new first_namespace_c1();
            second_namespace_c1 sc = new second_namespace_c1();
            fc.func();
            sc.func();
            Console.ReadKey;
        }
    }
}
