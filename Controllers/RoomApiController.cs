// création du contrôleur API 

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcGrandHotel.Data;
using MvcGrandHotel.Models;
namespace MvcGrandHotel.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomApiController : ControllerBase
{
    private readonly GrandHotelContext _context;
    public RoomApiController(GrandHotelContext context)
    {
        _context = context;
    }
    // GET: api/RoomApi
    public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
    {
        return await _context.Rooms.Include(r => r.Category).ToListAsync();
    }

    // GET: api/RoomApi/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Room>> GetRoom(int id)
    {
        // Find room and related enrollments
        // SingleAsync() throws an exception if no room is found (which is possible, depending on id)
        // SingleOrDefaultAsync() is a safer choice here
        var room = await _context.Rooms
            .Where(r => r.Id == id)
            .Include(r => r.Category)
            .SingleOrDefaultAsync();

        if (room == null)
            return NotFound();

        return room;
    }

    // POST: api/RoomApi
    [HttpPost]
    public async Task<ActionResult<Room>> PostRoom(Room room)
    {
        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetRoom), new { id = room.Id }, room);
    }
}