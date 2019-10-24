namespace PersonalRegister
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"NameToString: {Name} SalaryToString: {Salary}";
        }
    }
}