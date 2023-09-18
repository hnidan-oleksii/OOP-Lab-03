// Define a Class Person

public class Person
{
    private string name;
    private int age;

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age)
    {
        this.name = "No name";
        this.age = age;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}

