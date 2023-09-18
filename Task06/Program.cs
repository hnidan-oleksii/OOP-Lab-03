// Company Roaster

int n = int.Parse(Console.ReadLine());
Employee[] employees = new Employee[n];

for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split();

    string currName = values[0];
    double currSalary = double.Parse(values[1]);
    string currPosition = values[2];
    string currDepartment = values[3];
    string currEmail = "n/a";
    int currAge = -1;

    if (values.Length > 4)
    {
        bool isEmail = false;

        if (values[4].Contains('@'))
        {
            currEmail = values[4];
            isEmail = true;
        }

        if (!isEmail)
        {
            currAge = int.Parse(values[4]);
        }
        else if (values.Length == 6)
        {
            currAge = int.Parse(values[5]);
        }
    }

    employees[i] = new Employee(currName, currSalary, currPosition, currDepartment, currEmail, currAge);
}

var highestAvgSalaryDep = employees
    .GroupBy(employee => employee.Department)
    .Select(item => new
    {
        Dep = item.Key,
        AvgSalary = item.Average(employee => employee.Salary),
        Employees = item.OrderByDescending(employee => employee.Salary)
    })
    .OrderByDescending(dep => dep.AvgSalary)
    .First();

Console.WriteLine($"Highest Average Salary: {highestAvgSalaryDep.Dep}");

foreach (Employee employee in highestAvgSalaryDep.Employees)
{
    Console.WriteLine(employee);
}
