using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoqUnitTestSampleProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqUnitTestSampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _data;

        public CustomerController(ICustomerRepo data)
        {
            _data = data;
        }


        [HttpGet("[id]")]
        public string GetNameById(int id)
        {
            return _data.GetNameById(id);
        }
    }
}
