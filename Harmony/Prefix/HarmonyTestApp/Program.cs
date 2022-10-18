using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyTestLib;
using HarmonyLib;
using System.Security.Cryptography.X509Certificates;

namespace HarmonyTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            HarmonyInit.patchAll();

            animals.name = "steve";
            animals.legs = 2;

            int speed = animals.RunDistance(10);

            string animalName = animals.GetAndWriteName("james");

            Console.WriteLine(speed);
            Console.WriteLine(animalName);
            Console.ReadKey();
        }
    }

}
