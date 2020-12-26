using DependencyInjectionBasicExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionBasicExample.Service
{
    public class BusinessLogicService
    {
        IService iservice;

        public BusinessLogicService(IService _iservice)
        {
            iservice = _iservice;
        }

        public void AllUse()
        {
            iservice.GetFirstName();
            iservice.GetLastName();
            iservice.GetAddress();
            iservice.GetAge();
        }
    }
}
 