using System.Collections.Generic;

namespace EDC.DesignPattern.Visitor
{
    /// <summary>
    ///     对象结构类：EmployeeList
    /// </summary>
    public class EmployeeList
    {
        private readonly IList<IEmployee> empList = new List<IEmployee>();

        public void AddEmployee(IEmployee emp)
        {
            empList.Add(emp);
        }

        public void Accept(Department handler)
        {
            foreach (var emp in empList) emp.Accept(handler);
        }
    }
}