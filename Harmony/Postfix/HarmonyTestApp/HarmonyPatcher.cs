using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyTestLib;


namespace HarmonyTestApp
{
    public static class HarmonyPatcher
    {
        public static void doPatching()
        {
            var harmony = new Harmony("com.example.patch");
            harmony.PatchAll();
        }



        //PostFix Patch
        //      runs after a method has completed
        //      used to patch or replace the output of a method.

        // __result                 =   method output
        // ref string __result      = ref string (references the argument of type string)
        [HarmonyPatch(typeof(Animals), nameof(Animals.getAnimalName))]
        class Patch
        {
            static void Postfix(ref string __result)
            {
                if (__result.Contains("dog"))
                {
                    Console.WriteLine("it cat now");
                    __result = "cat";
                }
            }
        }
    }
}
