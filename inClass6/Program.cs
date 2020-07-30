using System;
using System.Security.Cryptography;

namespace inClass6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] names = new string[3];

            names[0] = "tom";
            names[1] = "Sarah";
            names[2] = "joey";
            names[0] = "jimmy";

            for(int i = 0; i<names.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(names[i]);
            }

            int[] nums = { 32, 86, 91, 40, 900, 826, 363, 28, 90 };

            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(i + ": " + nums[i]);
                total += nums[i];
            }

            Console.WriteLine("The total is: " + total);
            Console.WriteLine("The Average is " + total/nums.Length);

            int total2 = 0;

            foreach(int num in nums)
            {
                Console.WriteLine(num);
                total2 += num;
            }

            Console.WriteLine("Total 2 is: " + total2);
            Console.WriteLine("The Average is: " + total2/nums.Length);
            */

            int[] nums = { 109, 483, 11, 90, 7 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 100)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.WriteLine();
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            foreach (int num in nums)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine();
            foreach (int num in nums)
            {
                if (num < 100)
                {
                    Console.WriteLine();
                    break;
                }
            }

        }
    }
}
