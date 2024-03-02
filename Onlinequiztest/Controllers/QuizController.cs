using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Onlinequiztest.Models;
using System.Reflection;

namespace Onlinequiztest.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class QuizController : Controller
    {
        private readonly string _jsonFilePath = "data.json";

        [HttpGet]
        public async Task<List<Quiz>> Get()
        {
            using (StreamReader file = System.IO.File.OpenText(_jsonFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (List<Quiz>)serializer.Deserialize(file, typeof(List<Quiz>));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Quiz model)
        {
            var data = await Get() ?? new List<Quiz>();
            data.Add(model); // Add new data  

            using (StreamWriter file = System.IO.File.CreateText(_jsonFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
            return Ok();
        }
    }
}
    