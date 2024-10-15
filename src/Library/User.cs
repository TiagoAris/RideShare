namespace Library;

public abstract class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Id { get; set; }
    public int Rating { get; set; }

    protected User (string name, string surname, int id, int rating)
    {
        this.Name = name;
        this.Surname = surname;
        this.Id = id;
        this.Rating = rating;
    }
}