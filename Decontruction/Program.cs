using System;

namespace Decontruction
{
    public class Point
    {
        public int X, Y;
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var myPoint = new Point();
            var (x, _) = myPoint;  //if i didint write deconstruct func. Not working
            Console.WriteLine($"{x}");
        }
    }
}
