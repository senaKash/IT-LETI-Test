using Microsoft.AspNetCore.Mvc;
using Calculator.Contracts.Test;

namespace IT_LETI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get-test")]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Запрос опсос");
            return await Task.Run(Ok);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTest([FromBody] CreateTestDto model)
        {



        }


    }
}
