using System;
namespace Hello
{
    class Program
    {
        static void Main(String[] args)
        {
            bool find = false;
            int[] arr = { 60, 40, 30, 40 };
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (search == arr[i])
                    find = true;
                break;
            }
            if (find)

            {
                Console.WriteLine("Found value");
            }
            else
            {
                Console.WriteLine("Not Match");
            }
        }
    }
}