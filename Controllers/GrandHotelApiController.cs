using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcGrandHotel.Data;
using MvcGrandHotel.Models;
namespace MvcGrandHotel.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GrandHotelApiController : ControllerBase
{
    private readonly GrandHotelContext _context;
    public GrandHotelApiController(GrandHotelContext context)
    {
        _context = context;
    }
    // GET: api/GrandHotelApi
    public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
    {
        return await _context.Rooms.ToListAsync();
    }
}