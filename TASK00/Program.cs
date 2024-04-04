using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TASK00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part one
            int length, width, height;
            string userName = $"Hallo Mr {Environment.UserName}";
            string[] userName01 = userName.Split(' ');
            foreach (string part in userName01)
            {
                foreach (char c in part)
                {
                    Console.Write(c); Thread.Sleep(100);
                }
                Console.Beep();
                Thread.Sleep(200);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            Console.Write("plz provide me the length value");
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Black;
            length = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("plz provide me the width  value");
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Black;
            width = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("plz provide me the heigth value");
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Black;
            height = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"The Length = {length} m and The Width = {width} m and The Height = {height} m");
            Console.WriteLine("\n\n\n");
            #endregion
            #region Part two

            double beamLength, beamWeightOverMeter;
            Console.Write("Plz Enter The Length of the Beam ");
            beamLength = double.Parse(Console.ReadLine());
            Console.Write("Plz Enter The Weight Per Meter of The Beam ");
            beamWeightOverMeter = double.Parse(Console.ReadLine());
            Console.WriteLine($"So The Tottal Volume of The Beam = {beamLength * beamWeightOverMeter} Kg");
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Is The BedRoom Accessible to Disabled Individuals Y/N");
            Boolean isAccessible = true;
            string userAnser = Console.ReadLine();
            int loopBreaker = 0;


            do {
                if (userAnser == "Y" || userAnser == "y" || userAnser == "yes" || userAnser == "Yes")
                {
                    isAccessible = true;
                    Console.WriteLine("thanks for considering the disabled individuals needs in your design");
                    loopBreaker = 1;
                }
                else if (userAnser == "N" || userAnser == "n" || userAnser == "no" || userAnser == "No")
                {
                    isAccessible = false; Console.WriteLine("I think you have to change your design");
                    loopBreaker = 1;
                }
                else
                {
                    Console.WriteLine("we can not understand your answer plz answer with yes or no");
                    userAnser = Console.ReadLine();
                    loopBreaker = -1;
                }
            }
            while (loopBreaker == -1);
                
 
            
            




            Console.WriteLine("\n\n\n");

            char panelUniqueCode = 'A';
            Console.WriteLine($"The Unique Code to the electrical panel that you have purchasied is {panelUniqueCode}");
            Console.WriteLine("\n\n\n");
            #endregion
            #region Part three
            Console.WriteLine("Enter the Cost Per Unite Area For the Wanted flooring type");
            double cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Area of youe floor");
            double area = double.Parse(Console.ReadLine());
            double tottalCost = cost*area;
            Console.WriteLine($"The Tottal Cost of the flooring system is {tottalCost} EGP");
            #endregion



        }
    }
}
