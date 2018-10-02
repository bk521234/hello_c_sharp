using System;

namespace new_app
{
    class StringStuff
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* comparing strings */
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0) {
                Console.WriteLine(str1 + " and " + str2 +  " are equal.");
            } else {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.WriteLine();
            Console.ReadKey() ;

            /* string contains strings */
            string str = "This is test";

            if (str.Contains("test")) {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.WriteLine();

            /* getting a substring */
            string nstr = "Last night I dreamt of kittens";
            Console.WriteLine(nstr);
            string substr = nstr.Substring(23);
            Console.WriteLine(substr);
            Console.WriteLine();

            /* joining strings */
            string[] starray = new string[]{"Down the way nights are dark",
                                            "And the sun shines daily on the mountain top",
                                            "I took a trip on a sailing ship",
                                            "And when I reached Jamaica",
                                            "I made a stop"};

            string str_join = String.Join("\n", starray);
            Console.WriteLine(str_join);

            Console.ReadKey() ;

        }
    }
}
