using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvansedProject
{
    class MyString
    {
        public string Str { set; get; }

        public string ToUpper()
        {
            return Str.ToUpper();
        }

        public int CountChar(char ch)
        {
            int count = 0;
            foreach (char c in Str)
                if (c == ch)
                    count++;
            return count;
        }
    }

    public static class StringExtencion
    {
        public static int CountChar(this string str, char ch)
        {
            int count = 0;
            foreach (char c in str)
                if (c == ch)
                    count++;
            return count;
        }
    }

    partial class User
    {
        public void Print()
        {
            Console.WriteLine($"{Name} {Id}");
        }
    }
}
