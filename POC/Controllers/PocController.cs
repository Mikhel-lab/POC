using Microsoft.AspNetCore.Mvc;
using POC.Interfaces;
using POC.Models.FactoryEntity;
using POC.Models.LGAEntity;
using POC.Models.PocEntity;
using POC.Models.StateEntity;
using POC.Response;
using POC.Service.Implementation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PocController : ControllerBase
    {
        private readonly IPocService _pocService;

        public PocController(IPocService pocService)
        {
            _pocService = pocService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPoc([FromBody] Poc poc)
        {
            if (poc == null)
            {
                return BadRequest("Poc object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            await _pocService.AddPoc(poc);
            return Ok("Poc added successfully");
        }

       
        [HttpPost("add-state")]
        public async Task<IActionResult> AddSate([FromBody] State stat)
        {
            if (stat == null)
            {
                return BadRequest("Poc object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            await _pocService.AddState(stat);
            return Ok("Poc added successfully");
        }

        [HttpGet("allFactoryLocations")]
        public async Task<ActionResult<PocResponse<List<FactoryLocation>>>> GetAllFactoryLocations()
        {
            var result = await _pocService.getAllFactoryLocations();
            if (!result.Success)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpGet("allSates")]
        public async Task<ActionResult<PocResponse<List<State>>>> GetAllState()
        {
            var result = await _pocService.getAllState();
            if (!result.Success)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpGet("allLGA")]
        public async Task<ActionResult<PocResponse<List<LGA>>>> GetAllLGA()
        {
            var result = await _pocService.getAllLGA();
            if (!result.Success)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }

}
