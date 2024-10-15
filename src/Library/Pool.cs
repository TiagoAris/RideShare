namespace Library;

public class Pool : Driver
{
    public int Capacity { get; set; }
    public Pool(string name, string surname, int id, int rating, string vehicle, int capacity) : base(name, surname, id, rating, vehicle)
    {
        this.Capacity = capacity;
    }
}