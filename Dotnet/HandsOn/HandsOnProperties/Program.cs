namespace HandsOnProperties
{
    class Employee
    {
        private int eid;
        private string ename;
        //Property of eid
        public int EID
        {
            get { return eid; } //get accessor use to return private variable
            set { eid=value; } //set accessor use to set value to pirave variable
        }
        //Property of ename
        public string ENAME
        {
            get { return ename; }
            set { ename = value; }
        }
        public void Display()
        {
            System.Console.WriteLine($"Id:{eid} Name:{ename}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EID = 329732;
            employee.ENAME = "Rohan";
            employee.Display();
            Console.WriteLine($"EId {employee.EID} EName {employee.ENAME}");
            
        }
    }
}
