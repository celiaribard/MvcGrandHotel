// Création de la classe Category

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Room> Rooms { get; set; } = new();

}