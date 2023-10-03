namespace Lektion17Dist.Services;

public class Data
{
    List<string> Names { get; set; } = new();

    public Data()
    {
        for (int i = 0; i < 20; i++)
            Names.Add("Olle " + i.ToString());
    }

    public List<string> Get(int index, int count = 5)
    {
        return Names.Skip(index * count).Take(count).ToList();
    }

    public List<string> GetWithUnion() 
    {
        /*var list1 = Names.Take(5);
        var list2 = Names.Skip(10).Take(5);
        return list1.Union(list2).ToList();*/

        return Names.Take(5).Union(Names.Skip(10).Take(5)).ToList();
    }
}
