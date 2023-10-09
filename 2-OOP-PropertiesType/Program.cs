using System.Diagnostics.Tracing;

internal class Program
{
    private static void Main(string[] args)
    {
        //Propertyler 3 ayrılır.
		//Read-Write Property
		//Read Only Property
		//Static Property
		Person person = new Person();
		person.Name = "Test";
		Console.WriteLine(person.Name);

		Console.WriteLine(person.Name1);
    }
}

public class Person
{
	//Fields
	private string name;
	private int age;

	//Property
	public int Age
	{
		get { return age; }
		set 
		{
			if (value <= 35)
			{
                age = value;
            }
			else
			{
				Console.WriteLine("Öğrenci 35 den küçük olmalıdır.");
				age = 35;
			}
		}
	}
	//1-Read-Write Property
	public string Name
	{
		get { return name.ToUpper(); }
		set { name = value; }
	}

    //2-Read-Only Property
    public string Name1
    {
        get { return name.ToUpper(); }
    }

    public string Name2
    {
        get { return name.ToUpper(); }
        private set { name = value; }
    }

    //3-Write-Only Property
    public string Name3
    {
        set { name = value; }
    }

    public string Name4
    {
        private get { return name.ToUpper(); }
        set { name = value; }
    }
}