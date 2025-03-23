using CodeAlchemy.Core.Models;
using CodeAlchemy.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlchemy.API.Controllers
{
    [ApiController]
    [Route("api/compile")]
    public class CompilerController : ControllerBase
    {
        private readonly ICodeExecutionService _service;

        public CompilerController(ICodeExecutionService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> RunCode([FromBody] CodeRequest request)
        {
            var output = await _service.ExecuteCodeAsync(request.Code);
            
            return Ok(new { result = output });
        }
    }
}
