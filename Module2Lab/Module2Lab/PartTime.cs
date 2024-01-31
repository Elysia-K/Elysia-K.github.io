using System;
namespace Module2Lab
{
	public class PartTime : Employee
	{
		private double Rate { get; set; }
        private double Hours { get; set; }

        public PartTime()
		{
		}

		public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) :base(id, name, address,phone,sin, dob,dept)
		{

            this.Rate = rate;
            this.Hours = hours;
        }

        public virtual double GetPay()
        {
            return Rate * Hours;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nRate: {Rate}" + $"\nHours: {Hours}";
        }
    }

}

