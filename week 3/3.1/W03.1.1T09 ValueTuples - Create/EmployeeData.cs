class EmployeeData
{
    private readonly List<Employee> Employees;
    public EmployeeData(List<Employee> employees) => Employees = employees;

    public ValueTuple<decimal, decimal> GetSalaryRange()
    {
        decimal minSalary = decimal.MaxValue;
        decimal maxSalary = decimal.MinValue;

        foreach (var employee in Employees)
        {
            if (employee.Salary < minSalary)
                minSalary = employee.Salary;

            if (employee.Salary > maxSalary)
                maxSalary = employee.Salary;
        }

        return (minSalary, maxSalary);
    }
}
