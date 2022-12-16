// Création du fichier pour le remplissage de la base de données

using MvcGrandHotel.Data;
namespace MvcGrandHotel.Models;
public class SeedData
{
    public static void Init()
    {
        using (var context = new GrandHotelContext())
        {
            // Look for existing content
            if (context.Categories.Any())
            {
                return; // DB already filled
            }
            // Add several categories
            context.Categories.AddRange(
            new Category
            {
                Name = "Confort"
            },
            new Category
            {
                Name = "Luxe"
            },
            new Category
            {
                Name = "Prestige"
            }
            );

            // Look for existing content
            if (context.Rooms.Any())
            {
                return; // DB already filled
            }

            // Add several rooms

            // context.Rooms.AddRange(
            // new Room
            // {
            //     Name = "Calypse",
            //     Description = "Une chambre belle et fonctionnelle",
            //     Price = 140,
            //     CategoryId = 1
            // }
            // );


            // Commit changes into DB
            context.SaveChanges();
        }
    }
}
