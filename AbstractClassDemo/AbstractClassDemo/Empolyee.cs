using System;

namespace AbstractClassDemo
{
    public abstract class Empolyee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        private DateTime HireDate;

        public virtual void Hire()
        {
            HireDate = DateTime.Now;
        }

        public abstract void GiveRaise();
    }
}