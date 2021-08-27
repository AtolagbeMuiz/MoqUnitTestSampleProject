using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqUnitTestSampleProject.Classes
{
    public interface ICustomerRepo
    {
        string GetNameById(int id);
    }
}
