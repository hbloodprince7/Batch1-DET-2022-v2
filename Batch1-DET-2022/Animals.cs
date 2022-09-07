using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public abstract class Animals
    {
        string name;
        string gender;
        int age;

        public abstract string Sound();
    }
    public class Dog : Animals
    {
        public override string Sound()
        {
            return "Bow - Wow";
        }
    }
    public class Cat : Animals
    {
        public override string Sound()
        {
            return "Meow";
        }
    }
    public class Cow : Animals
    {
        public override string Sound()
        {
            return "Moo";
        }
    }
}
