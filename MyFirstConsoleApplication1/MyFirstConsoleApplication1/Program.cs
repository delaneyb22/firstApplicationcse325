using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication1;
   
  internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Delaney Baker";
            string location = "Missouri, USA";

            //string interpolation
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Console.WriteLine("The current date is {0}", date);



            int daysUntilXmas = 101;
            Console.WriteLine($"There are {daysUntilXmas} days until Christmas!");


            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //I think this is what the assignment means by
            //"provide appropriate text labels when requesting dimensional input"
            //but i'm not sure.
            Console.WriteLine("enter the width in inches");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);


            Console.WriteLine("enter the height in inches");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");


            //step 7 use console.readkey()
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            //push to github

        }


    }

    

