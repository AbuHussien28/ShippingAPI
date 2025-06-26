using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingAPI.UnitOfWorks;

namespace ShippingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiessController : ControllerBase
    {
        private readonly UnitOfWork uow;

       public CitiessController(UnitOfWork Uow)
        {
            uow = Uow;
        }

        public IActionResult GetCities()
        {
            var cities = uow.CityRepo.getAll();
            return Ok(cities);
        }
    }
}
