using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyTestLib;
using HarmonyLib;

namespace HarmonyTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            HarmonyPatcher.doPatching();
            Animals animal = new Animals();

            animal.name = "Steve";
            string getNameString = animal.getAnimalName("dog");
            Console.WriteLine(getNameString);
            Console.ReadKey();
        }
    }
}
