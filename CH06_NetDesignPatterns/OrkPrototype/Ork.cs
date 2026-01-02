using Newtonsoft.Json;

public class Ork
{
    public int Age { get; set; }
    public int Strenght { get; set; }
    public int Speed { get; set; }
    public Ork copyOrk()
    {
        //Serializujemy bieżący obiekt do tekstu JSON
        string json = JsonConvert.SerializeObject(this);

        //Z tekstu JSON tworzymy nowy obiekt Ork
        Ork clone = JsonConvert.DeserializeObject<Ork>(json)!;

        return clone;
    }

    public override string ToString()
    {
        return $"Ork(Age={Age}, Strenght={Strenght}, Speed={Speed})";
    }
}