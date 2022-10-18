using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace ThingCompTutorial
{

    //A thing comp is a specific type of component that is attached to a ThingWithComps.
    //ThingWithComps Examples:
    //      1. Pawns
    //      2. Plants
    //      3. Equipment
    //      4. Buildings
    public class ExampleThingComp : ThingComp
    {
        // In order to inherit the thing comps properties (from CompProperties Class below) and values (from XML)
        public ThingCompExample_CompProperties Props => (ThingCompExample_CompProperties)this.Props;
        //public List<String> TestString => Props.ExampleStringList;
        public string AnExampleString => Props.ExampleString;

    }
    public class ThingCompExample_CompProperties : CompProperties
    {

        //Comp Properties match can be set in xml
        //public List<String> ExampleStringList = new List<String>();
        public string ExampleString;

        public ThingCompExample_CompProperties()
        {
            Log.Message("this is a test");
            compClass = typeof(ExampleThingComp);
        }
    }
}
