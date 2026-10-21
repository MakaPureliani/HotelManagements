using HotelManagements.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagements.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult GetRooms()
        {
            return Ok( _roomService.GetRooms());
        }

        [HttpGet]
        public IActionResult GetRoom(int roomNumber)
        {
            return Ok(_roomService.GetRoom(roomNumber));
        }
    }
}
