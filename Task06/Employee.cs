class Employee
{
    public string Name { get; }
    public double Salary { get; }
    public string Position { get; }
    public string Department { get; }
    public string Email { get; }
    public int Age { get; }

    public Employee(string Name, double Salary, string Position, string Department, string Email, int Age)
    {
        this.Name = Name;
        this.Salary = Salary;
        this.Position = Position;
        this.Department = Department;
        this.Email = Email;
        this.Age = Age;
    }

    public override string ToString()
    {
        return $"{Name} {Salary.ToString("0.00")} {Email} {Age}";
    }
}
