using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagniUniAPI.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Name = "Joao",
                    Id = 1,
                    Birthday = "1990-01-01",
                    RegistrationNumber = "123",
                    Grade = "8"
                }
            };
        }
    }
}

