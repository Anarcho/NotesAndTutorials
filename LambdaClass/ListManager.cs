using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaClass
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person { FirstName = "Blaire", LastName = "Kellard", Birthday = Convert.ToDateTime("8/03/2022"), YearsExperience = 98});
            output.Add(new Person { FirstName = "Knox", LastName = "Keuneke", Birthday = Convert.ToDateTime("16/02/2022"), YearsExperience = 43 });
            output.Add(new Person { FirstName = "Anya", LastName = "Entissle", Birthday = Convert.ToDateTime("14/04/2022"), YearsExperience = 1 });
            output.Add(new Person { FirstName = "Chip", LastName = "Askwith", Birthday = Convert.ToDateTime("25/06/2022"), YearsExperience = 87 });
            output.Add(new Person { FirstName = "Marley", LastName = "Crosscombe", Birthday = Convert.ToDateTime("29/01/2022"), YearsExperience = 7 });

            return output;
        }
    }
}
