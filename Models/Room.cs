// Création de la classe Room
using System.ComponentModel.DataAnnotations;

public class Room
{
    public int Id { get; set; }

    [Display(Name = "Nom")]
    public string Name { get; set; } = null!;
    public string? Description { get; set; }

    [Display(Name = "Prix (€)")]
    public double Price { get; set; }
    public int CategoryId { get; set; }

    [Display(Name = "Catégorie")]
    public Category Category { get; set; } = null!;

    // Constructeur par défaut
    public Room() { }

    public override string ToString()
    {
        return $"Id: {Id}, Room name: {Name}, Description: {Description}, Price: {Price}, CategoryId: {CategoryId}";
    }
}