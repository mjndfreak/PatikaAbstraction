namespace PatikaPolymorphism.Concrete;

public class ProjectManager : BaseEmployed
{
    public override void Job()
    {
        Console.WriteLine("I'm a project manager.");
    }

    public void Info()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Surname: " + Surname);
        Console.WriteLine("Department: " + Department);
        Job();
    }
}

