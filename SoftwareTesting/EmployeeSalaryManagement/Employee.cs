using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement
{
    public class Employee
    {
        //public Employee(int id,string name,string dutyStation,decimal wage,int workDays,bool isMarried,int totalDependancies,bool isDanger,bool hasPensionPlan, HealthInsurancePackage healthInsurancePackage, WorkPlatform workPlatform)
        //{
        //    Id= id;
        //    Name= name;
        //    DutyStation= dutyStation;
        //    Wage= wage;
        //    IsMarried= isMarried;
        //    TotalDependancies= totalDependancies;
        //    IsDanger= isDanger;
        //    WorkingDays= workDays;
        //    HasPensionPlan= hasPensionPlan;
        //    HealthInsurancePackage = healthInsurancePackage;
        //    WorkPlatform = workPlatform;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string DutyStation { get; set; }
        public decimal Wage { get; set; }
        public int WorkingDays { get; set; }
        public bool IsMarried { get; set; }
        public int TotalDependancies { get; set; }
        public bool IsDanger { get; set; }
        public bool HasPensionPlan { get; set; }
        public HealthInsurancePackage? HealthInsurancePackage { get; set; }
        public WorkPlatform WorkPlatform { get; set; }
    }
}
