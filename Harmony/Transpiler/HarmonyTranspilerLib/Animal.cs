using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTranspilerLib
{
    public class Animal
    {
        public string Name;

        public void writeAnimalType(string animalType)
        {
            //Transpiler will be animalType = "puppy";
            //after
            
            if (animalType == "dog")
            {
                Console.WriteLine("dog");
            }
            else if (animalType == "puppy")
            {
                Console.WriteLine("puppy");
            }
            else
            {
                Console.WriteLine("cat");
            }
        }
    }
}
