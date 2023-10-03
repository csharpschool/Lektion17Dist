namespace Lektion17Dist.Classes;

public enum Species
{
    Cat,
    Dog,
    Rabbit,
    Donkey
}

public class Pet : IComparable<Pet>
{
    public int Id { get; init; }
    public string Name { get; init; }
    public Species Species { get; init; }

    public Pet(int id, string name, Species species) =>
        (Id, Name, Species) = (id, name, species);

    public int CompareTo(Pet? other)
    {
        // other parametern jämförs med egenskapsvärden i det aktuella objektet
        
        if (other == null) return 1;
        if (this == other) return 0; // Jämför objektsreferenserna
        if (Id > other.Id) return 1;
        if (Id < other.Id) return -1;
        if (Id == other.Id) return 0;
        return 0;
    }
}
