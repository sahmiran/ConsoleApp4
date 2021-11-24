using System;

namespace ConsoleApp4
{
    class Program
    {
        

            static void Main(string[] args)
            {
                var random = new Random();
                int num1, num2, num3, num4, num5,sssk;


                for (int i = 0; i < 132; i++)
                {
                    int randomnumber = random.Next(0,150);
                    if (randomnumber % 2 != 0)
                    {
                        Console.Write(randomnumber + " ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Enter 5 positive numbers");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                num3 = Convert.ToInt32(Console.ReadLine());
                num4 = Convert.ToInt32(Console.ReadLine());
                num5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("__________________________________________");

                Console.WriteLine("5th Root of first number " + Math.Pow(num1, 1.0 / 5));
                Console.WriteLine("5th Root of second number " + Math.Pow(num2, 1.0 / 5));
                Console.WriteLine("5th Root of third number " + Math.Pow(num3, 1.0 / 5));
                Console.WriteLine("5th Root of forth number " + Math.Pow(num4, 1.0 / 5));
                Console.WriteLine("5th Root of fifth number " + Math.Pow(num5, 1.0 / 5));


                Console.WriteLine("__________________________________________");
                Console.Write("How many number do you want?   ");
                sssk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            Console.WriteLine("Sum of the {0} random numbers that are 2 digits and ends with 5= " + Sss(sssk), sssk);

                Console.WriteLine("__________________________________________");
                Console.WriteLine("Enter a,b and c values:   ");
                int a =Convert.ToInt32( Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());

                int result = Sss(Math.Abs(c - b) * Math.Abs(c + a));
                Console.WriteLine("Sss(|c-b|)*Sss(a+c)= " + result);
            }

            static public int Sss(int k)
            {
                var randomSss = new Random();
                int sum = 0;
                //we assumed  numbers are between 0 and 150
                for (int i = 0; i < k; i++)
                {
                    int randomnumber = randomSss.Next(0, 150);
                    //Checking if random number has 2 digit and ends with 5 
                    if (randomnumber / 10 > 0 && randomnumber % 10 == 5)
                    { 
                        sum += randomnumber;     
                    }
                
                }

                return sum;
            }

        }

    }

