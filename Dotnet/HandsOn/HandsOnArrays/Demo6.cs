using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo6
    {
        static void Main()
        {
            Console.WriteLine("Enter a no");
            int no=int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("1.Even/Odd\n2.Math Table\n3.Print Natural no's\n4.Exit");
                Console.WriteLine("Enter Option");
                int option=int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            if (no % 2 == 0)
                                Console.WriteLine("Even No");
                            else
                                Console.WriteLine("Odd No");
                           // Console.WriteLine(no % 2 == 0 ? "Even" : "Odd");
                        }
                        break;
                    case 2:
                        {
                            for(int i=1;i<=10;i++)
                            {
                                Console.WriteLine($"{no}*{i}={no * i}");
                            }
                        }
                        break;
                    case 3:
                        {
                            int k = 1;
                            while(k<=no)
                            {
                                Console.Write(k + " ");
                                k++;
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Environment.Exit(0); //exit app
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }while(true);
        }
    }
}
