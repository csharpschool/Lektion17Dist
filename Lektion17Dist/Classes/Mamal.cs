using System.Xml.Linq;

namespace Lektion17Dist.Classes;

public class Mamal
{
    public int Id { get; init; }
    public string Species { get; init; }

    public Mamal(int id, string species) =>
        (Id, Species) = (id, species);
}
