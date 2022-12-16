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

            // Add several rooms

            context.Rooms.AddRange(
            new Room
            {
                Name = "Calypse",
                Description = "Une chambre belle et fonctionnelle.",
                Price = 140,
                CategoryId = 1
            },
            new Room
            {
                Name = "Grand Bleu",
                Description = "Une chambre simple mais élégante, au décor rappelant l'océan.",
                Price = 150,
                CategoryId = 1
            },
            new Room
            {
                Name = "Pacific",
                Description = "Vaste et aérée, elle est décorée uniquement de bois marin.",
                Price = 175,
                CategoryId = 2
            },
            new Room
            {
                Name = "Normandy",
                Description = "Notre chambre la plus élégante. Tout ici respire le rafinnement.",
                Price = 240,
                CategoryId = 3
            }
            );

            // Commit changes into DB
            context.SaveChanges();
        }
    }
}
