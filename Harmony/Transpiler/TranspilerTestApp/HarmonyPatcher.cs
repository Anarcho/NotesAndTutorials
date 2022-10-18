using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using HarmonyTranspilerLib;
using TranspilerTestApp;

namespace TranspilerTestApp
{
    public class HarmonyPatcher
    {
        public static void doPatcher()
        {
            var harmony = new Harmony("com.example.patcher");
            harmony.PatchAll();
        }

        [HarmonyPatch(typeof(Animal), nameof(Animal.writeAnimalType))]
        class Patch_Transpiler_Magic
        {
            static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                //if found set in the if statement - used to stop the for loop from seeing any other op codes.
                var found = false;

                // sets the list of IL codes to codes variable
                var codes = new List<CodeInstruction>(instructions);

                //sets last as the last opcode that has been reached in the for loop.
                OpCode last = codes[0].opcode;
                for (int i = 0; i < codes.Count; i++)
                {
                    if(!found && last == OpCodes.Nop && codes[i].opcode == OpCodes.Ldarg_1)
                    {
                        
                        yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(HarmonyInit), "writeTests"));
                        yield return new CodeInstruction(OpCodes.Starg_S);
                        found = true;
                    }
                    else
                    {
                        yield return codes[i];
                    }

                    last = codes[i].opcode;
                }

                if(!found)
                {
                    Console.WriteLine("failed to find codes");
                    yield break;
                }
            }
        }
    }
}
