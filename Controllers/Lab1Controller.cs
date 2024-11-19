using Lab1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lab1Controller : ControllerBase
    {
        public IActionResult Get()
        {
            Lab1Model game106 = new Lab1Model
            {
                CourseName = "Game Development",
                CourseCode = "GAM106",
                Name = "Huy Hoang",
                StudentCode = "123456",
                Class = "A"
            };
            int status = 1;
            string message = "Get data sucsses!";
            var data = new { status, message, game106 };
            return new JsonResult(game106);
        }
    }
}
