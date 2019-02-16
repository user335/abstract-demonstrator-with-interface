using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();

        static void Main()
        {
            var employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            Console.Read();

            IQuittable quitter = new Employee();
            quitter.Quit();
        }
    }
}
