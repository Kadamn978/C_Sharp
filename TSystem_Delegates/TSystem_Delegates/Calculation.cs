namespace TSystem_Delegates
{
    public delegate int MyDelegate(int a, int b);
    public delegate int MyStringDelegate(string name);
    public class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }

    }
    public class Test
    {
        public string AcceptName(string name)
        {
            return name.ToUpper();
        }
        
    } 
}
