using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqUnitTestSampleProject.Classes
{
    public class CustomerRepo : ICustomerRepo
    {
        public string GetNameById(int id)
        {
            string name;
            if (id == 1)
            {
                name = "Muiz";
            }
            else if (id == 2)
            {
                name = "Maryam";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}
