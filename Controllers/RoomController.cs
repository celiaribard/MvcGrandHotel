// Contrôleur pour l'affichage de la page Chambres

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcGrandHotel.Data;
using MvcGrandHotel.Models;

namespace MvcGrandHotel.Controllers;

public class RoomController : Controller
{
    private readonly GrandHotelContext _context;

    public RoomController(GrandHotelContext context)
    {
        _context = context;
    }

    // GET: Room
    public async Task<IActionResult> Index()
    {
        var rooms = await _context.Rooms
            .OrderBy(r => r.Name)
            .ToListAsync();

        return View(rooms);
    }

    // GET: Room/Details/5
    // public async Task<IActionResult> Details(int? id)
    // {
    //     if (id == null)
    //     {
    //         return NotFound();
    //     }

    //     // Lookup student and associated enrollments
    //     var student = await _context.Students
    //         .Include(s => s.Enrollments)
    //         .ThenInclude(e => e.Course)
    //         .FirstOrDefaultAsync(m => m.Id == id);
    //     if (student == null)
    //     {
    //         return NotFound();
    //     }

    //     return View(student);
    // }
}
