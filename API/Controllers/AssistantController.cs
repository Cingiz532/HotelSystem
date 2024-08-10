using Business.Abstract;
using Entitties.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistantController : ControllerBase
    {
        IAssistantManager _assistantManager;
        public AssistantController(IAssistantManager assistantManager)
        {
            _assistantManager = assistantManager;
        }
        [HttpPost("addAssistant")]
        public IActionResult AddAssistant(Assistant assistant)
        {
            var result = _assistantManager.Add(assistant);
            if(result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpDelete("deleteAssistant")]
        public IActionResult DeleteAssistant(int id)
        {
            var result = _assistantManager.Delete(id);
            if(result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpGet("getAssistantById")]
        public IActionResult GetAssistant(int id)
        {
            var result = _assistantManager.GetById(id);
            if( result.IsSuccess )
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpGet("getAllAssistant")]
        public IActionResult GetAllAssistant()
        {
            var result =_assistantManager.GetAll();
            if(result.IsSuccess )
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }    
        }
    }
}
