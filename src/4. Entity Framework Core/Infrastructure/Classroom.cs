namespace EfCore.Infrastructure;

public class Classroom
{
    public Classroom(Guid id): this(string.Empty, id)
    {
    }

    public Classroom(string name, Guid id)
    {
        Name = name;
    }

    public Guid Id { get; private set; }

    public string Name { get; private set; }
}