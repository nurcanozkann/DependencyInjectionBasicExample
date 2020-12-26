using DependencyInjectionBasicExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionBasicExample.Concrete
{
    public class TeacherService : IService
    {
        public void GetAddress()
        {
            Console.WriteLine("Teacher Address");
        }

        public void GetAge()
        {
            Console.WriteLine("Teacher Age");
        }

        public void GetFirstName()
        {
            Console.WriteLine("Teacher Firstname");
        }

        public void GetLastName()
        {
            Console.WriteLine("Teacher Lastname");
        }
    }
}
