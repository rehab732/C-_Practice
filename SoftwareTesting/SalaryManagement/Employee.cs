namespace SalaryManagement
{
    public class Employee
    {
        public Employee(
            int id,
            string name,
            string dutyStation,
            bool ismarried,
            int totalDependences,
            int wage,
            bool isDanger,
            bool hasPensionPlan,
            HealthInsurancePackage health,
            WorkPlatform workPlatform
            )
        {
            Id = id;
            Name = name;
            DutyStation = dutyStation;
            IsMarried = ismarried;
            IsDanger = isDanger;
            Wage = wage;
            HasPensionPlan = hasPensionPlan;
            HealthInsurancePackage = health;
            WorkPlatform = workPlatform;

        }



        public int Id { get; set; }
        public string Name { get; set; }
        public string DutyStation { get; set; }
        public bool IsMarried { get; set; }
        public int TotalDependenceis { get; set; }
        public int Wage { get; set; }
        public bool IsDanger { get; set; }
        public bool HasPensionPlan { get; set; }
        public HealthInsurancePackage? HealthInsurancePackage { get; set; }
        public WorkPlatform WorkPlatform { get; set; }
    }
}
