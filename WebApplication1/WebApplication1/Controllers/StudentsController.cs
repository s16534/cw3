using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.StudentsController
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            } else if(id == 2)
            {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono studenta");
        }

        [HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Kowalski, Malewski, Andrzejewski, sortowanie={orderBy}";
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpDelete]
        public string delete(string remove)
        {
            return $"Usuwanie ukończone {remove}";
        }

        [HttpPut]
        public string put(string put)
        {
            return $"Aktulizacja ukończona {put}";
        }

    }
}
