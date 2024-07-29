namespace MyLibrary
{
    public class Calculate
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public int Mul(int a, int b)
        {
            return a*b;
        }
        public double Div(double a, double b)
        {
            try
            {
                if (b == 0)
                    throw new DivideByZeroException("b value should not be 0");
                else
                    return a/b;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
