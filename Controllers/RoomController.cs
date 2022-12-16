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
            // .OrderBy(r => r.Name)
            .Include(r => r.Category)
            .ToListAsync();

        return View(rooms);
    }

}
