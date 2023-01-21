using CabBooking.Models;
using CabBooking.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CabBooking.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RiderController : ControllerBase
    {
        private readonly ITripService _tripService;
        private readonly IRiderService _riderService;

        public RiderController(ITripService tripService, IRiderService riderService)
        {
            _tripService = tripService;
            _riderService = riderService;
        }

        [HttpPost]
        public void RegisterRider([FromBody] Rider rider)
        {
            _riderService.RegisterRider(rider);
        }

        [HttpPost]
        public void BookRide([FromBody] BookRide bookRide)
        {
            _tripService.CreateTrip(_riderService.GetRider(bookRide.RiderId), bookRide.FromLocation, bookRide.ToLocation);
        }

        [HttpGet]
        public IEnumerable<Trip> GetTrips(int riderId)
        {
            return _tripService.TripHistory(_riderService.GetRider(riderId));
        }
    }
}
