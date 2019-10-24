namespace PersonalRegister
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; set; }
        public SalaryLevel SalaryLevel
        {
            get
            {
                if (Salary < 33000)
                {
                    return SalaryLevel.Junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            }
        }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary} Level: {SalaryLevel}";
        }
    }

    public enum SalaryLevel
    {
        Junior,
        Senior
    }
}