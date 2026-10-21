using Azure.Core;
using HotelManagements.Entities;
using HotelManagements.Interfaces;
using HotelManagements.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagements.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {

        private readonly IGuestService _guestService;
        public GuestsController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpPost]
        public IActionResult AddGuest(AddGuestRequest request)
        {
            _guestService.AddGuest(request);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetGuest(int id)
        {

            return Ok(_guestService.GetGuest(id));
        }
        [HttpGet]
        public IActionResult GetGuests()
        {

            return Ok(_guestService.GetGuests());
        }
    }
}
