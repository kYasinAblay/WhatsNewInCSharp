using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pattern_MatchingWithGenerics
{

    public class Animal
    {

    }

    public class Cow : Animal
    {

    }

    public class PatternMatchingWithGenerics
    {
        public static void Cook<T>(T animal)
          where T : Animal
        {
            // note the red squiggly!
            // cast is redundant here
            if ((object)animal is Cow cow)
            {
                // cook and eat it
                Write("We cooked and ate the pig...");
            }

            switch (/*(object)*/animal)
            {
                case Cow mug:
                    WriteLine(" and it tastes delicious!");
                    break;
            }
        }

        /// <summary>
        /// Need to fall back to C# 7 for this.
        /// </summary>
        static void Main(string[] args)
        {
            var cow = new Cow();
            Cook(cow);
        }
    }
}
