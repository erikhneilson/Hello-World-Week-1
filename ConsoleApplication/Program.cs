using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using System.Speech.Synthesis;

namespace ConsoleApplication
{
    public class Program

    {
        //static void Main(string[] args)
        static void Main()
        {

            var currentCountry = RegionInfo.CurrentRegion.DisplayName;
            Console.WriteLine("REQUIREMENT #2");
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("REQUIREMENT #3");
            Console.WriteLine("My Name is Erik Neilson");
            Console.WriteLine("I'm from Portland Oregon!");
            Console.WriteLine(currentCountry);
            String name = "Erik";
            Console.WriteLine("");
            Console.WriteLine("REQUIREMENT #4");
            //Console.WriteLine("Hello, ", name); BROKEN IGNORE
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine($"Hello, {name}" + "!");
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine(String.Format("Hello, {0}", name + "!"));

            Console.WriteLine("REQUIREMENT #5");
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "en-US" };
            Console.WriteLine("");

            Console.WriteLine("** Time/Date Formatting **");
            Console.WriteLine("Zone,  MM,DD,YYYY, Time AM/PM ");
            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}: {1}", cultureName,
                                  localDate.ToString(culture));
            }
            DateTime today = DateTime.Today;
            //Console.WriteLine("Today is " + today.ToString("MMMM dd, yyyy"));

            DateTime Christmas = new DateTime(DateTime.Today.Year, 12, 25);
            TimeSpan daysToChristmas = Christmas - DateTime.Today;
            Console.WriteLine("");
            Console.WriteLine("REQUIREMENT #6");
            Console.WriteLine("** Xmas Countdown **");
            Console.WriteLine($" {daysToChristmas.TotalDays} day(s) remain until Christmas");
            double width, LengthWood, height, glassArea;
            string widthString, heightString;
            Console.WriteLine("");

            Console.WriteLine("REQUIREMENT #7");
            Console.WriteLine("** Measurement Inputs **");
            Console.Write("Please enter the width (in FT): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Please enter the height (in FT): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            LengthWood = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            LengthWood + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metre(s)");
            //Console.ReadLine();


            // The example displays something similar to the following output:
            //       Hello World!
            //       My Name is Erik Neilson
            //       I'm from Portland Oregon!
            //       Hello Erik
            //       Hello Erik   
            //       Hello Erik
            //
            //       Time / Date
            //            Month, Day, Year, Hour, Minute, Second, AM/PM
            //       en-US: 6/19/2015 10:03:06 AM
            // 
            //       Christmas Countdown
            //
            //       VAR day(s) left till Christmas
            //
            //       Input Measurements 


            Console.WriteLine("Please Press any key to exit.");
            Console.ReadKey();
        }
    }
}


