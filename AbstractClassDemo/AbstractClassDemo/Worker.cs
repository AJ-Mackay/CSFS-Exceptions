namespace AbstractClassDemo
{
    public class Worker : Empolyee
    {
        public override void GiveRaise()
        {
            Salary += Salary * 0.03;
        }
    }
}