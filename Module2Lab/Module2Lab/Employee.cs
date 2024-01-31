using System;
namespace Module2Lab
{

	public class Employee
	{
		private string EmployeeId { get; set; }
		private string EmployeeName { get; set; }
		private string EmployeeAddress { get; set; }
        private string EmployeePhone { get; set; }
        private long EmployeeSin { get; set; }
        private string EmployeeDob { get; set; }
        private string EmployeeDept { get; set; }

        public Employee()
		{
		}

		public Employee( string id, string name, string address, string phone, long sin, string dob, string dept)
		{
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.EmployeeAddress = address;
            this.EmployeePhone = phone;
            this.EmployeeSin = sin;
            this.EmployeeDob = dob;
            this.EmployeeDept = dept;
        }


        public override string ToString()
        {
            return $"ID:{this.EmployeeId}\n" +
                $"Name: {this.EmployeeName}\n" +
                $"Address: {this.EmployeeAddress}\n" +
                $"Phone: {this.EmployeePhone}\n" +
                $"SIN: {this.EmployeeSin}\n" +
                $"Date of Birth: {this.EmployeeDob}\n" +
                $"Department: {this.EmployeeDept}";
        }
    }
}

