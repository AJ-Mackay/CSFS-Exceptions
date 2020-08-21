namespace AbstractClassDemo
{
    public class Manager : Empolyee
    {
        public override void GiveRaise()
        {
            Salary += Salary * 0.05;
        }
    }
}