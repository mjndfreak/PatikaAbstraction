namespace PatikaPolymorphism;

public abstract class BaseEmployed
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }

    public abstract void Job();

}