using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("get-ass")]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Запупа стопапупа(сработал get-ass)");
            return await Task.Run(Ok);
        }

        /*
        [HttpPost("sasiPipku")]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostPisos model)
        {

        }
        */
    }
}
