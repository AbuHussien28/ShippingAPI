using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingAPI.DTOS;
using ShippingAPI.Models;
using ShippingAPI.UnitOfWorks;

namespace ShippingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class rejonsController : ControllerBase
    {
        private readonly UnitOfWork uow;
        private readonly IMapper map;

        public rejonsController(UnitOfWork uow, IMapper map)
        {
            this.uow = uow;
            this.map = map;
        }

        [HttpGet]
        public IActionResult GetRejons()
        {
            var rejons = uow.RegionRepo.getAll();
            if (rejons == null || !rejons.Any())
            {
                return NotFound("There Are No Rejons!");
            }
            var newRejons = map.Map<List<regoinDTO>>(rejons);
            return Ok(newRejons);
        }

        [HttpPost]
        public IActionResult AddRejon(regoinDTO rejonDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var rejon = map.Map<Region>(rejonDto);
            uow.RegionRepo.add(rejon);
            uow.save();
            return CreatedAtAction(nameof(GetRejons), new { id = rejon.Id }, rejonDto);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetRejonById(int id)
        {
            var rejon = uow.RegionRepo.getById(id);
            if (rejon == null)
            {
                return NotFound("The Rejon Is Not Found");
            }
            var rejonDto = map.Map<regoinDTO>(rejon);
            return Ok(rejonDto);
        }
        [HttpGet("getrejonbyname/{name}")]
        public IActionResult GetRejonByName(string name)
        {
            var rejon = uow.RegionRepo.getByName(name);
            if (rejon == null)
            {
                return NotFound("The Rejon Is Not Found");
            }
            var rejonDto = map.Map<regoinDTO>(rejon);
            return Ok(rejonDto);
        }
        [HttpPut]
        public IActionResult editRegion(regionidDTO regionidDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var region = uow.RegionRepo.getById(regionidDTO.Id);
            if (region == null)
            {
                return NotFound("The Region Is Not Found");
            }
            map.Map(regionidDTO, region);
            uow.RegionRepo.edit(region);
            uow.save();
            return Ok("Region Updated Successfully");
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteRegion(int id)
        {
            var region = uow.RegionRepo.getById(id);
            if (region == null)
            {
                return NotFound("The Region Is Not Found");
            }
            uow.RegionRepo.delete(id);
            uow.save();
            return Ok("Region Deleted Successfully");

        }
    }
}
