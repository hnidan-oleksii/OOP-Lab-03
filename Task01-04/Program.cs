// Define a Class Person + Creating Constructors

Person person1 = new() { Name = "Pesho", Age = 20 };
Person person2 = new Person();
Person person3 = new Person();

person2.Name = "Gosho";
person3.Name = "Stamat";

person2.Age = 18;
person3.Age = 43;

// Oldest Family Member

Family family = new Family();

int n1 = int.Parse(Console.ReadLine());
for (int i = 0; i < n1; i++)
{
    string[] currInp = Console.ReadLine().Split();
    string currName = currInp[0];
    int currAge = int.Parse(currInp[1]);

    family.AddMember(new Person(currName, currAge));
}

Console.WriteLine("{0}\n\n",family.GetOldestMember());


// Opinion Poll

int n2 = int.Parse(Console.ReadLine());
Person[] persons = new Person[n2];
for (int i = 0; i < n2; i++)
{
    string[] currInp = Console.ReadLine().Split();
    string currName = currInp[0];
    int currAge = int.Parse(currInp[1]);

    persons[i] = new Person(currName, currAge);
}

Person[] filteredPersons = persons
    .Where(person => person.Age > 30)
    .OrderBy(person => person.Name)
    .ToArray();

foreach (Person person in filteredPersons)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}
