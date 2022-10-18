using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTestLib
{
    public class Animals
    {
        public string name;
        public int age;
        
        public string getAnimalName(string animalType)
        {
            string animalName = "This animal is a " + animalType + " and it's name is "+ this.name;
            Console.WriteLine(animalName);
            return animalName;
        }
    }
}
