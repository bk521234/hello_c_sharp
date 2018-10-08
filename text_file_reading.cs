using System;
using System.IO;

namespace FileApplication{
    class Program{
        static void Main(string[] args){
            try{
                // create an instance of StreamReader to read from a file.
                // the using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("c:/jamaica.txt")) {
                    string line;

                    // read and display lines from the file until
                    // the end of the file is reached.
                    while ((line = sr.ReadLine()) != null) {
                        Console.WriteLine(line);
                    }
                }
            } catch (Exception e){
                // let the user know what went wrong.
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

