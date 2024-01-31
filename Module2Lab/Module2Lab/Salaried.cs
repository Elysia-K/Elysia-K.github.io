using System;
namespace Module2Lab
{
	public class Salaried : Employee
	{
		private double Salary { get; set; }

        public Salaried()
		{
		}

		public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) : base(id, name, address, phone, sin, dob, dept)
		{
			this.Salary = salary;
		}

		public virtual double GetPay()
		{
			return Salary;
		}

        public override string ToString()
		{
            return base.ToString() + $"\nSalary: {Salary}";
        }
	}
}

