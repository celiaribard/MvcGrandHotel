// Création du contexte BD qui sera utilisé par les contrôleurs pour interagir avec la BD

using Microsoft.EntityFrameworkCore;
using MvcGrandHotel.Models;

namespace MvcGrandHotel.Data;

public class GrandHotelContext : DbContext
{
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Room> Rooms { get; set; } = null!;

    public string DbPath { get; private set; }

    public GrandHotelContext()
    {
        // Path to SQLite database file
        DbPath = "MvcGrandHotel.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        //options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }

}