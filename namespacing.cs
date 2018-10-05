using System;

namespace first_namespace{
    class namespace_c1{
        public void func(){
            Console.WriteLine("Inside first_namespace");
        }
    }
}
namespace second_namespace{
    class namespace_c1{
        public void func(){
            Console.WriteLine("Inside second_namespace");
        }
    }
    class TestClass{
        static void Main(string[] args){
            first_namespace.namespace_c1 fc = new first_namespace.namespace_c1();
            second_namespace.namespace_c1 sc = new second_namespace.namespace_c1();
            fc.func();
            sc.func();
            Console.ReadKey;
        }
    }
}
