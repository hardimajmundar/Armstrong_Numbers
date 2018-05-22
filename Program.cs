using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 0, reminder = 0, sum = 0;
            string number = "";
            char[] num1;
            Console.WriteLine("Enter the number:");
            no = int.Parse(Console.ReadLine());

            number = Convert.ToString(no);
            num1 = number.ToArray();

            for (int i = 0; i < num1.Length; i++)
            {
                int j = num1[i];
                reminder = j * j * j;
                sum = sum + reminder;
            }
            if (sum == no)
            {
                Console.Write("Entered number is an Armstraong number");
            }
            else
            {
                Console.Write("Entered number is not an Armstraong number");
            }

            Console.ReadKey();
        }
    }
}
