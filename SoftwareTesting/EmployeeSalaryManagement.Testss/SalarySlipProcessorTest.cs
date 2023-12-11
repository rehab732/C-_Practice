using Moq;
using SalaryManagement;

namespace EmployeeSalaryManagement.Testss
{
    public class SalarySlipProcessorTest
    {
        //[Fact]
        //public void MethodName_Senario_OutCome()
        //{

        //}

        //public decimal CalculateBasicSalary(Employee employee)
        //{
        //    //if (employee == null)
        //    //    throw new ArgumentNullException(nameof(employee));

        //    return employee.Wage * employee.WorkingDays;
        //}
        [Fact]
        public void CalculateBasicSalary_ForEmployeeWithSalaryAndWage_ReturnsBasicSalary()
        {
            //Arrange
            Employee employee = new Employee { Wage = 500m, WorkingDays = 20 };
            //Act
            var salarySlip = new SalarySlipProcessor(null);
            var actual = salarySlip.CalculateBasicSalary(employee);
            var expected = 10000m;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateBasicSalary_ForEmployeeEqualNull_ReturnsException()
        {
            //Arrange
            Employee employee = null;
            //Act
            var salarySlip = new SalarySlipProcessor(null);
            Func<Employee, decimal> func = (e) => salarySlip.CalculateBasicSalary(employee);

            //Assert
            Assert.Throws<ArgumentNullException>(() => func(employee));
        }

        //public decimal CalculateDangerPay(Employee employee)
        //{

        //    if (employee == null)
        //        throw new ArgumentNullException(nameof(employee));
        //    if (employee.IsDanger)
        //        return Constant.DangerPayAmount;
        //    var isDAngerZone = _zoneService.IsDangerZone(employee.DutyStation);
        //    if (isDAngerZone)
        //        return Constant.DangerPayAmount;
        //    return 0m;
        //}

        [Fact]
        public void CalculateDangerPay_ForDangerEmployee_RetrunsDangerPayAmount()
        {
            //Arrange
            Employee employee = new Employee { IsDanger = true };
            //Act
            var salarySlip = new SalarySlipProcessor(null);
            var actual = salarySlip.CalculateDangerPay(employee);
            var expected = Constant.DangerPayAmount;
            //aSSERT
            Assert.Equal(actual, expected);


        }

        [Fact]
        public void CalculateDangerPay_ForNotDangerEmployee_Retruns0m()
        {
            //Arrange
            Employee employee = new Employee { IsDanger = false };
            //Act
            var salarySlip = new SalarySlipProcessor(null);
            var actual = salarySlip.CalculateDangerPay(employee);
            var expected = 0m;
            //aSSERT
            Assert.Equal(actual, expected);


        }
        [Fact]
        public void CalculateDangerPay_ForNullEmployee_ReturnsException()
        {
            //Arrange
            Employee employee = null;
            //Act
            var salarySlip = new SalarySlipProcessor(null);
            Func<Employee, decimal> func = (e) => salarySlip.CalculateBasicSalary(employee);

            //Assert
            Assert.Throws<ArgumentNullException>(() => func(employee));

        }


        [Fact]
        public void CalculateDangerPay_ForDangerEmployeeandDangerZone_ReturnsDangerPayAmount()
        {
            //Arrange
            Employee employee = new Employee { IsDanger = true, DutyStation = "Helwan" };
            var mock = new Mock<IZoneService>();
            var setUp = mock.Setup(z => z.IsDangerZone(employee.DutyStation)).Returns(true);
            //Act
            var salarySlip = new SalarySlipProcessor(mock.Object);
            var actual = salarySlip.CalculateDangerPay(employee);
            var expected = Constant.DangerPayAmount;

            //Assert
            Assert.Equal(actual, expected);

        }




        [Fact]
        public void CalculateDangerPay_ForNotDangerEmployeeandNotDangerZone_Returns0m()
        {
            //Arrange
            Employee employee = new Employee { IsDanger = false, DutyStation = "Helwan" };
            var mock = new Mock<IZoneService>();
            var setUp = mock.Setup(z => z.IsDangerZone(employee.DutyStation)).Returns(false);
            //Act
            var salarySlip = new SalarySlipProcessor(mock.Object);
            var actual = salarySlip.CalculateDangerPay(employee);
            var expected = 0m;

            //Assert
            Assert.Equal(actual, expected);

        }


    }
}