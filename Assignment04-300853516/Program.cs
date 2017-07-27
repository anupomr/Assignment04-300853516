using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Anupom Roy
 * Date: July 27, 2017
 * Description: This is the driver class for my project
 * Version: 0.1 - Implemented the GiantPlanet Class and TerrestrialPlanet class
 */
namespace Assignment04_300853516
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlant = new GiantPlanet("second planet from the Sun", "Venus", 12104, 4.867);
            Console.WriteLine(giantPlant.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet(true, "Earth",12742, 4.867);
            Console.WriteLine(terrestrialPlanet.ToString());

            WaitForAnyKey();
        }
        public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    } 
}
