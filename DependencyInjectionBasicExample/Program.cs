using DependencyInjectionBasicExample.Concrete;
using DependencyInjectionBasicExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionBasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogicService businessLogicService = new BusinessLogicService(new TeacherService());
            businessLogicService.AllUse();
            Console.ReadLine();
        }
    }
}
