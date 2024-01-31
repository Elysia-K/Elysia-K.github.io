using System;
namespace Module2Lab
{
    public class Wages : Employee
    {
        private double Rate { get; set; }
        private double Hours { get; set; }

        public Wages()
        {
        }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Rate = rate;
            this.Hours = hours;

        }

        public virtual double GetPay()
        {
            double wage = 0.0;
            if (Hours <= 40)
            {
                wage = Rate * Hours;
            }
            else
            {
                wage = (Rate * 40) + (Rate * 1.5 * (Hours - 40));
            }

            return wage;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nRate: {Rate}"+$"\nHours: {Hours}";
        }
    }
}

