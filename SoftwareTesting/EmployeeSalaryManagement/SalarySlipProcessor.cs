using SalaryManagement;

namespace EmployeeSalaryManagement
{
    public class SalarySlipProcessor
    {
        private readonly IZoneService _zoneService;
        public SalarySlipProcessor(IZoneService zoneService)
        {
            _zoneService = zoneService;
        }
        public decimal CalculateBasicSalary(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            return employee.Wage * employee.WorkingDays;
        }

        public decimal CalculateDangerPay(Employee employee)
        {

            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            if (employee.IsDanger)
            {
                return Constant.DangerPayAmount;
            }
            else
            {
                return 0m;
            }
            var isDAngerZone = _zoneService.IsDangerZone(employee.DutyStation);
            if (isDAngerZone)
            {
                return Constant.DangerPayAmount;
            }
            else
            {
                return 0m;
            }
            return 0m;
        }
    }
}
