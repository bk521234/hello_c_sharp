using System;

namespace ArrayApplication{
    class MyArray{
        static void Main(string[] args){
            int [] n = new int[10]; 

            for (int i = 0; i < 10; i++){
                n[i] = i + 100;
            }

            foreach (int j in n){
                int i = j-100;
                Console.WriteLine("Element[{0}] =  {1}", i, j);
            }
            Console.ReadKey();

            // multi dimensional arrays
            /* an array with 5 rows and 2 columns */
            int[,] a = new int[5,2]{{0,0}, {1,2}, {2,4}, {3,6}, {4,8}};
            int i, j;

            /* output each array element's value */
            for (i = 0; i<5; i++){
                for (j = 0; j<2; j++){
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i,j]);
                }
            }
            Console.ReadKey();

            /* working with jagged arrays - A Jagged array is an array of arrays */
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2}, new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;
         
            /* output each array element's value */
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 2; j++) {
                Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}