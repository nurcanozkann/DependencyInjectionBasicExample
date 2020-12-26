using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionBasicExample.Abstract
{
    public interface IService
    {
        void GetFirstName();
        void GetLastName();
        void GetAge();
        void GetAddress();
    }
}
