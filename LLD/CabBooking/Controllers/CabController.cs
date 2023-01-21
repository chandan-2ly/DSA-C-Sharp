using CabBooking.Models;
using CabBooking.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CabBooking.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CabController : ControllerBase
    {
        private readonly ICabService _cabService;
        private readonly ITripService _tripService;
        private readonly ILogger<CabController> _logger;

        public CabController(ICabService cabService, ITripService tripService, ILogger<CabController> logger)
        {
            _cabService = cabService ?? throw new ArgumentNullException(nameof(cabService));
            _tripService = tripService ?? throw new ArgumentNullException(nameof(tripService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        // GET: api/<CabController>
        [HttpGet]
        public IEnumerable<Cab> GetCabs()
        {
            return _cabService.GetAllRegisteredCabs();
        }

        // GET api/<CabController>/5
        [HttpGet]
        public Cab GetCab(int id)
        {
            return _cabService.GetCab(id);
        }

        // POST api/<CabController>
        [HttpPost]
        public IActionResult RegisterCab([FromBody] Cab cabDetails)
        {
            _cabService.RegisterCab(cabDetails);
            return Ok("Success");
        }

        [HttpPut]
        public void UpdateCabLocation(int cabId, [FromBody] Location location)
        {
            _cabService.UpdateLocation(cabId, location);
        }

        [HttpPut]
        public void UpdateCabAvailability(int cabId, bool availability)
        {
            _cabService.UpdateAvailability(cabId, availability);
        }

        [HttpPut]
        public void UpdateCabStatus(int cabId, CabStatus cabStatus)
        {
            _cabService.UpdateStatus(cabId, cabStatus);
        }

        [HttpPost]
        public void EndTrip(int cabId)
        {
            _tripService.EndTrip(cabId);
        }
    }
}
