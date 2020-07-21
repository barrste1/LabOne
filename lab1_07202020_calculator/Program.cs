using System;
using System.Runtime.CompilerServices;

namespace lab1_07202020_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room designer! Let's order some trim, some carpet, and determine how much room we have to work with!");
            //variable cont is the variable used to break the loops if the user is out of rooms to measure.
            int cont = 0;
            while (cont < 1)
            {
                Console.WriteLine("What is the length of the room (in meters)?");
                decimal length = decimal.Parse(Console.ReadLine());
                Console.WriteLine("What is the width of the room (in meters)?");
                decimal width = decimal.Parse(Console.ReadLine());
                Console.WriteLine("What is the height of the room (in meters)?");
                decimal height = decimal.Parse(Console.ReadLine());
                decimal perimeter = ((2 * length) + (2 * width));
                decimal area = (length * width);
                decimal volume = (length * width * height);
                decimal surfaceArea = ((2 * length * width) + (2 * length * height) + (2 * height * width));
                //A room's area should be useful for the amount of carpet you need, and the perimeter around the room should be the amount of trim needed, as it goes around the room.
                //Volume is Length x Width x Height
                Console.WriteLine("You will be needing " + perimeter + " m of trim, and " + area + " m² of carpet!");
                Console.WriteLine("The size of the room is " + volume + " m³, with a surface area of " + surfaceArea + " m².");
                    while (cont == 0)
                        {
                        Console.WriteLine("Are there any other rooms I can assist you with (Y/ N)?");
                        string input = Console.ReadLine();
                        input.ToUpper();
                    //validation that only "Y" or "N" responses are given to continue.
                        if (input == "N")
                        {
                            cont++;
                        }
                        else if (input == "Y")
                        {
                            Console.WriteLine("Excellent! What are the other dimensions?");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response. Please respond with Y or N.");
                        }

                }


            }

            Console.WriteLine("Have a nice day!");
        }

    }
}

