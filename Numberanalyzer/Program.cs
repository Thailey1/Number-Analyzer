// See https://aka.ms/new-console-template for more information
namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 100 :");
            string integer = Console.ReadLine();
            int number;

         
            if (int.TryParse(integer, out number))
            {
                
                if (number >= 1 && number <= 100)
                {
                    if (number % 2 != 0 && number < 60)
                    {
                        Console.WriteLine(number + " is odd and less than 60.");
                    }
                    else if (number % 2 == 0 && number >= 2 && number <= 24)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (number % 2 == 0 && number >= 26 && number <= 60)
                    {
                        Console.WriteLine("Even and between 26 and 60 inclusive.");
                    }
                    else if (number % 2 == 0 && number > 60)
                    {
                        Console.WriteLine(number + " is even and greater than 60.");
                    }
                    else if (number % 2 != 0 && number > 60)
                    {
                        Console.WriteLine(number + " is odd and greater than 60.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid . Please enter an integer between 1 and 100."); 

                }
            }
            
           
         
        }
    }
}

