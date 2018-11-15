using System;

namespace SampleApp{
    public delegate string MyDel(string str);

    class EventProgram{
        event MyDel MyEvent;

        public EventProgram(){
            this.MyEvent += new MyDel(this.WelcomeEser);
        }
        public string WelcomeUser(string username){
            return "Welcome " + username;
        }
        static void Main(string[] args){
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Your Name!!!!");
            Console.WriteLine(result);
        }
    }
}

