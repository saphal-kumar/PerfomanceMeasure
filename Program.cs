using System;

namespace PerfomanceMeasure
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new  Employee(){Name = "Saphal Kumar", Designation = "SSE", EmpID = 1, Department = new Department() {DepartmentID = 1, DepartmentName = "IT"}};
            Console.WriteLine(emp.ToString());
        }
    }
}
