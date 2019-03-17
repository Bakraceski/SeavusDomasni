using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Input 5 number");
            int[] numbers = new int[5];
            string num0 = Console.ReadLine();
            int a = int.Parse(num0);
            numbers[0] = a;
            string num1= Console.ReadLine();
            int b = int.Parse(num1);
            numbers[1] = b;
            string num2 = Console.ReadLine();
            int c = int.Parse(num2);
            numbers[2] = c;
            string num3 = Console.ReadLine();
            int d = int.Parse(num3);
            numbers[3] = d;
            string num4 = Console.ReadLine();
            int f = int.Parse(num4);
            numbers[4] = f;
            for ( int i = 0; i<numbers.Length;i++)
            {
                sum += numbers[i];
            }
           
            Console.WriteLine("The Sum of numbers is:" + sum);
            Console.ReadLine();
        }
        
    }
    

}