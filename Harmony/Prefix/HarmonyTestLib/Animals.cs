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
        public int legs;

        public int RunDistance(int distance)
        {
            if(this.legs == 0)
            {
                Console.WriteLine("cant run");
                return 0;
            }
            else if(this.legs > 0 && this.legs < 4)
            {
                Console.WriteLine("run small distance");
                return this.legs * distance;
            }
            else
            {
                Console.WriteLine("run far distance");
                return (this.legs * distance) + 15;
            }
        }

        public string GetAndWriteName(string name)
        {
            this.name = name;
            Console.WriteLine(name);

            return name;
        }
    }
}
