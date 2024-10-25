using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static float V { get; private set; }

        static void Main(string[] args)
        {
            string name,pass;
            Console.WriteLine("enter your name: \n");
            name = Console.ReadLine();
            Console.WriteLine("enter your password: \n");
            pass = Console.ReadLine();
            if( (name == "Radwa") && (pass == "123456789")){

              Console.WriteLine("wellcome, " + name);
              Console.ReadKey();
            }
            else if( !(pass =="123456789"))
            {
                Console.WriteLine("password is not correct");
               
            }
            else if (!(name == "Radwa"))
            {
                Console.WriteLine("user name is not correct");

            }


            Console.ReadKey();
                
               
            
        }
    }
}
