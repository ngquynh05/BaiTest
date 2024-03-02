using System;

namespace Array
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1: ");
            Bai_1();
            Console.WriteLine("Bai 2: ");
            Console.WriteLine("nhap vao n: \t");
            Bai_2();
            Console.WriteLine("\n");
            Console.WriteLine("Bai 3: ");
            Console.WriteLine("nhap vao n: \t");
            Bai_3();
         
        }

        static void Bai_1()
        {
            int a = 100;
            for (int i = 0; i < a; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " Fizz Buzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");

                }
            }
        }


        static void Bai_2()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                
                Console.Write(arr[i] + " ");
            }

        }

        public static int SumOfArray(int[] arr, int n)
        {
            if (n == 1) return arr[0];
            return arr[n - 1] + SumOfArray(arr, n - 1);
        }

        static void Bai_3()
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(SumOfArray( arr, n));

        }

    }
}


