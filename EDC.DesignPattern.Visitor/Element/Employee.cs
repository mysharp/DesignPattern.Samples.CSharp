namespace EDC.DesignPattern.Visitor
{
    /// <summary>
    ///     抽象元素类：Employee
    /// </summary>
    public interface IEmployee
    {
        void Accept(Department handler);
    }

    /// <summary>
    ///     具体元素类：FullTimeEmployee
    /// </summary>
    public class FullTimeEmployee : IEmployee
    {
        public FullTimeEmployee(string name, double weeklyWage, int workTime)
        {
            Name = name;
            WeeklyWage = weeklyWage;
            WorkTime = workTime;
        }

        public string Name { get; set; }
        public double WeeklyWage { get; set; }
        public int WorkTime { get; set; }

        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }

    /// <summary>
    ///     具体元素类：PartTimeEmployee
    /// </summary>
    public class PartTimeEmployee : IEmployee
    {
        public PartTimeEmployee(string name, double hourWage, int workTime)
        {
            Name = name;
            HourWage = hourWage;
            WorkTime = workTime;
        }

        public string Name { get; set; }
        public double HourWage { get; set; }
        public int WorkTime { get; set; }

        public void Accept(Department handler)
        {
            handler.Visit(this);
        }
    }
}