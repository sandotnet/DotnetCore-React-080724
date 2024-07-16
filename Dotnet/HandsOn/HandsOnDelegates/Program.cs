namespace HandsOnDelegates
{
    //delegate declaration
    public delegate void MyDelegate();
    public delegate void GreetDelegate(string n);
    internal class Program
    {
       public void Task()
        {
            Console.WriteLine("Task is Running");
        }
        public static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            //instatiate delegate
            //here delegate object refer Task method
            MyDelegate myDelegate = new MyDelegate(obj.Task);
            //calling delegate object
            myDelegate(); //invoke method(Task) which refere by delegate MyDelegate
           GreetDelegate greetDelegate=new GreetDelegate(Program.Greet);
            greetDelegate("Virat");
        }
    }
}
