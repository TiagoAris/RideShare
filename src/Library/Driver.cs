namespace Library;

public class Driver : User
{
    public string Vehicle { get; set; }
    public Driver(string name, string surname, int id, int rating, string vehicle) : base(name, surname, id, rating)
    {
        this.Vehicle = vehicle;
    }
}