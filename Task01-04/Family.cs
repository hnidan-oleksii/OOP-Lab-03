// Creating Constructors

public class Family
{
    List<Person> persons = new List<Person>();
    public void AddMember(Person person) => persons.Add(person);
    public Person GetOldestMember() => persons.MaxBy(person => person.Age);
}
