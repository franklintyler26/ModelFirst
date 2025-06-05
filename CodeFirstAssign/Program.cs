using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataInput input = new DataInput();

            while (true)
            {
               
                Console.WriteLine("1->Insert Department");
                Console.WriteLine("2->Insert Employee");
                Console.WriteLine("Enter Your choice");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    input.InsertDept();
                }

                else if (choice == 2)
                {
                    input.Insertdata();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
