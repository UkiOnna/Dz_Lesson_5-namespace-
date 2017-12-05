using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person;

namespace Dz_Lesson_5_namespace_
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();

            //SecondTask();

            Console.ReadLine();
        }

        private static void SecondTask()
        {
            Console.WriteLine("Имя - {0}  Возраст - {1}",ConstNumberAndString.name,ConstNumberAndString.age);
        }

        private static void FirstTask()
        {
            Perrson person = new Perrson();
            string personInfo= Person.StaticMethod.GetPersonInfo(person);
            Console.WriteLine(personInfo);
        }
    }
}
