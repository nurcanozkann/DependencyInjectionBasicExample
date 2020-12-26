using DependencyInjectionBasicExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionBasicExample.Concrete
{
    public class StudentService : IService
    {
        public void GetAddress()
        {
            Console.WriteLine("Student Adress");
        }

        public void GetAge()
        {
            Console.WriteLine("Student Age");
        }

        public void GetFirstName()
        {
            Console.WriteLine("Student Firstname");
        }

        public void GetLastName()
        {
            Console.WriteLine("Student Lastname");
        }
    }
}
