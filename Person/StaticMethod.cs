using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class StaticMethod
    {


        public static string GetPersonInfo(Perrson person)
        {
            string infoPerson = "Имя - " + person.GetName() + " Возраст - " + person.GetAge();
            return infoPerson;
        }


    }
}
