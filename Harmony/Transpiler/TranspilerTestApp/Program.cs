using HarmonyTranspilerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranspilerTestApp;

namespace TranspilerTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            HarmonyPatcher.doPatcher();

            Animal animal = new Animal();

            animal.writeAnimalType("steve");
            Console.ReadKey();
        }
    }
}
