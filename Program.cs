using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age; 
            string name,temp ;
            Console.WriteLine("Enter your name");
            name=Console.ReadLine();
            Console.WriteLine("Hi, " + name + " Welcome How old are you?");                  
            age=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < age; i++) {     
           Console.WriteLine("are you "+ i );
            Console.WriteLine( " INPUT Y to continue / N to stop ");
                temp=Console.ReadLine();
                if (temp.Equals("N") || temp.Equals("n")) { 
                    continue;
                }
                    else if(temp.Equals("Y") || temp.Equals("y")) { 
                        Console.WriteLine("you stoped at age "+ i);
                        break;
              }
            }
            Console.WriteLine(name + " you are " + age + " years old!");
            Console.ReadLine();
        }
    }
}
