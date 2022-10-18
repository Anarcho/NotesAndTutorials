using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyTestLib;
using HarmonyLib;
using System.Xml.Linq;

namespace HarmonyTestApp
{
    public static class HarmonyInit
    {
        public static void patchAll()
        {
            var harmony = new Harmony("com.company.project.product");
            harmony.PatchAll();
        }
    }

    //Patch the Animals Class
    [HarmonyPatch(typeof(Animals))]
    //Patch the Animals.RunDistanceMethod
    [HarmonyPatch("RunDistance")]

    // __Instance   =   the object itself
    // __Result     =   the result of the method.

    class Patch01
    {

        //Access Tools Example:
        //  Accesses a field in the class and references it as legNum to be used in the method.
        //  static AccessTools.FieldRef<Animals, int> legNum = AccessTools.FieldRefAccess<Animals, int>("legs");


        //Prefix Method
        //  runs before the patched method is run.
        //  ref int ___legs is referencing the legs field in the object and uses it as an arguement - like this.legs
        // ref int distance is referencing the method argument distance.

        static bool Prefix(ref Animals __instance, ref int __result, ref int ___legs, ref int distance)
        {
            //  legNum was set in access tools fieldref.
            //  legNum(__instance) = 20;
            __result = ___legs * 100;


            // write line the method argument.
            Console.WriteLine(distance);

            //  Return false will skip the rest of the method.
            //  Return true will allow the method to run.
            return false;
        }
    }
}
