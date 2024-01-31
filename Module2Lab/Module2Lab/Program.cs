namespace Module2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            using (StreamReader reader = new StreamReader("/Users/elysia/Sait/OOP2_C#/Module2Lab/Module2Lab/res/employees.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(':');

                    string employeeId = values[0].Trim();
                    string employeeName = values[1].Trim();
                    string employeeAddress = values[2].Trim();
                    string employeePhone = values[3].Trim();
                    long employeeSin = long.Parse(values[4].Trim());
                    string employeeDob = values[5].Trim();
                    string employeeDept = values[6].Trim();

                    char firstDigit = employeeId[0];

                    if (firstDigit >= '0' && firstDigit <= '4')
                    {
                        double salary = double.Parse(values[7].Trim());
                        Salaried salaried = new Salaried(employeeId, employeeName, employeeAddress, employeePhone, employeeSin, employeeDob, employeeDept, salary);
                        employeeList.Add(salaried);
                    }
                    else if (firstDigit >= '5' && firstDigit <= '7')
                    {
                        double rate = double.Parse(values[7].Trim());
                        double hours = double.Parse(values[8].Trim());
                        Wages wages = new Wages(employeeId, employeeName, employeeAddress, employeePhone, employeeSin, employeeDob, employeeDept, rate, hours);
                        employeeList.Add(wages);
                    }
                    else if (firstDigit == '8' || firstDigit == '9')
                    {
                        double rate = double.Parse(values[7].Trim());
                        double hours = double.Parse(values[8].Trim());
                        PartTime partTime = new PartTime(employeeId, employeeName, employeeAddress, employeePhone, employeeSin, employeeDob, employeeDept, rate, hours);
                        employeeList.Add(partTime);
                    }
                    else
                        break;
                }
            }

            // Calculate and display average salary
            Console.WriteLine($"***Average Salary*** \n{CalculateAvgSalary(employeeList):F2}");

            // Display employee with the highest weekly pay
            Console.WriteLine($"***Highest Weekly Pay*** \n{GetHighestWeeklyPayEmployee(employeeList).ToString()}");

            // Display employee with the lowest salary
            Console.WriteLine($"***Lowest Salary*** \n{GetLowestSalaryEmployee(employeeList).ToString()}");

            // Display percentage of employees in each category
            DisplayPercentageOfEmployees(employeeList);
        }

        private static double CalculateAvgSalary(List<Employee> employees)
        {
            double totalSalary = 0.0;
            foreach (Employee employee in employees)
            {
                if (employee is Salaried)
                    totalSalary += ((Salaried)employee).GetPay();
                else if (employee is Wages)
                    totalSalary += ((Wages)employee).GetPay();
                else if (employee is PartTime)
                    totalSalary += ((PartTime)employee).GetPay();
            }

            return totalSalary / employees.Count;
        }


        private static Employee GetHighestWeeklyPayEmployee(List<Employee> employees)
        {
            Employee highestPaidEmployee = null;
            double maxWeeklyPay = 0.0;

            foreach (Employee employee in employees)
            {
                double weeklyPay = 0.0;

                if (employee is Salaried)
                    weeklyPay = ((Salaried)employee).GetPay();
                else if (employee is Wages)
                    weeklyPay = ((Wages)employee).GetPay();
                else if (employee is PartTime)
                    weeklyPay = ((PartTime)employee).GetPay();

                if (weeklyPay > maxWeeklyPay)
                {
                    maxWeeklyPay = weeklyPay;
                    highestPaidEmployee = employee;
                }
            }

            return highestPaidEmployee;
        }

        private static Employee GetLowestSalaryEmployee(List<Employee> employees)
        {
            Employee lowestPaidEmployee = null;
            double minSalary = double.MaxValue;

            foreach (Employee employee in employees)
            {
                double salary = 0.0;

                if (employee is Salaried)
                    salary = ((Salaried)employee).GetPay();
                else if (employee is Wages)
                    salary = ((Wages)employee).GetPay();
                else if (employee is PartTime)
                    salary = ((PartTime)employee).GetPay();

                if (salary < minSalary)
                {
                    minSalary = salary;
                    lowestPaidEmployee = employee;
                }
            }

            return lowestPaidEmployee;
        }

        private static void DisplayPercentageOfEmployees(List<Employee> employees)
        {
            int salariedCount = 0, wagesCount = 0, partTimeCount = 0;

            foreach (Employee employee in employees)
            {
                if (employee is Salaried)
                    salariedCount++;
                else if (employee is Wages)
                    wagesCount++;
                else if (employee is PartTime)
                    partTimeCount++;
            }

            int totalEmployees = employees.Count;

            double salariedPercentage = Math.Round((double)salariedCount / totalEmployees * 100, 2);
            Console.WriteLine($"Salaried Percentage: {salariedPercentage}%");

            double wagesPercentage = Math.Round((double)wagesCount / totalEmployees * 100, 2);
            Console.WriteLine($"Wages Percentage: {wagesPercentage}%");

            double partTimePercentage = Math.Round((double)partTimeCount / totalEmployees * 100, 2);
            Console.WriteLine($"PartTime Percentage: {partTimePercentage}%");
        }
    }
}


