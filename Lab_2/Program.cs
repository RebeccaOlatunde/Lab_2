using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Welcome to Grandcircus Room Detail Generator!");
            {
                String response = "";
                do
                {
                    //Measurement input prompts
                    
                    double l, w;
                    Console.WriteLine("Enter the length of the snug or penthouse");
                    l = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the width of the snug or penthouse");
                    w = Convert.ToDouble(Console.ReadLine());

                    //Formula for Area and Perimeter
                    
                    double area = l * w;
                    double peri = 2 * (l + w);

                    Console.WriteLine("Area of Rectangle is = {0} and Perimeter is ={1}", area, peri);

                    
                    Console.WriteLine("Do you want to Continue? (y/n)");

                    response= Console.ReadLine().ToLower();
                }
                   while (response == "y");

                   Console.WriteLine("Thank you for using Room Detail Genereator!");


           
            //MEASUREMENT FOR SNUG ROOM
            // Enter the length of the snug rectangle = 24.6
            // Enter the width of the snug rectangle = 20
            // Area of snug rectangle = 492
            // Perimeter of snug rectangle = 89.2

            // MEASUREMENT FOR THE PENTHOUSE
            // Enter the length of Penthouse = 42.6
            // Enter the width of the penthouse = 16.6
            // Area of Penthouse = 707.16
            // Perimeter of penhouse = 118.4
        }
    }
    }
}
