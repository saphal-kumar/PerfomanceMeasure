class Employee
{
    public int EmpID { get; set; }

    public string Name { get; set; }

    public string Designation { get; set; }

    public Department Department { get; set; }

    public override string ToString()
    {
        return @$"EmpID : {EmpID} , Name: {Name}";
    }
}