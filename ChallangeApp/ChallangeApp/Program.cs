

Employee employee1 = new Employee("Slawek","Kowalski", "38");
Employee employee2 = new Employee("Juanusz","Nowak", "25");
Employee employee3 = new Employee("Jacek", "Bilczynski", "33");

employee1.AddScore(4);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(8);
employee1.AddScore(10);



employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(7);



employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(5);





List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;
foreach( var employee in employees)
{
    if(employee.Result > maxResult) 
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;

    }
};

Console.WriteLine( $" Paracownik z najwięskszą ilością punków: {employeeWithMaxResult.Name}" +" "+ 
    $"{employeeWithMaxResult.Surname} " +  $"{employeeWithMaxResult.Age}"
    + $" lat i otrzymał : {employeeWithMaxResult.Result}"); 
    


class Employee
{
    private List<int> score = new List<int>();
    public Employee (string name, string surname,string age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        
    }

    public string Name { get; private set; }

    public string Surname { get; private set; }

    public string Age { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }

    public void AddScore (int number)
    {
        this.score.Add(number);

    }
}