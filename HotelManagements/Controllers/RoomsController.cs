
using HotelManagements.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagements.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly RoomServices _roomService;
        public RoomsController(RoomServices roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult GetRooms(DateTime? startDate, DateTime? endDate)
        {
            return Ok( _roomService.GetRooms(startDate,endDate));
        }

        [HttpGet]
        public IActionResult GetRoom(int roomNumber)
        {
            return Ok(_roomService.GetRoom(roomNumber));
        }
    }
}
