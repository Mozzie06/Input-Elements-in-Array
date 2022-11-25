using System;

namespace Program {

    class Arrays {

        public static void Main(string[]args) {

            int[] arr = new int[10];

            int i;

            

            Console.WriteLine("Input 10 elements");

            for(i = 0; i < 10; i++){

                Console.Write($"Element #{i} : ");

                arr[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();

            

            for(i = 0; i<arr.Length; i++){

                Console.Write(arr[i]+ " ");

            }

        }

    }

}
