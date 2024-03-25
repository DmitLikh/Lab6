using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            foreach (char c in str)
            if(str2 == c + str2)
            Console.WriteLine("Является палиндромом");
            else
            Console.WriteLine("Не является палиндромом");
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}



            
        
    

