using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LambdaExpressions;
using Fare;

namespace LambdaExpressionsTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            var DiseaseNameList = TestLambdaClass.LoadSampleData();

            Random rnd1 = new Random();
            int randIndex = rnd1.Next(DiseaseNameList.Count);
            string random = DiseaseNameList[randIndex];
            string random2 = "";



            while(random != random2)
            {
                Random rnd2 = new Random();
                randIndex = rnd2.Next(DiseaseNameList.Count);
                random2 = DiseaseNameList[randIndex];
                break;
            }

            Console.WriteLine($"{ random } { random2}");
            Console.ReadKey();
        }
    }
}
