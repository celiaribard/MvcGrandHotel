// Création de la classe Room

public class Room
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    // Constructeur par défaut
    public Room() { }


}