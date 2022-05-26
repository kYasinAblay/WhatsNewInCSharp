using System;

namespace RefAssemblies
{
    // /out
    // /refonly
    // /refout

    // csc RefAssemblyDemo..cs /refout:Demo.dll

    public class Person
    {
        private int id;
        protected string Name { get; set; }

        public void SayHello() => Console.WriteLine("Hi, I'm {Name}");

        static void Main(string[] args)
        {
            new Person().SayHello();
        }
    }
}
