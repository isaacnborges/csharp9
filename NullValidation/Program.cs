using System;

namespace NullValidation
{
    //https://github.com/dotnet/csharplang/issues/2145

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string name = null;
            //OtherManipulateString(Name);
        }

        //private string Test(string text!)
        //{
        //    return text;
        //}

        //public static string OtherManipulateString(string s!!)
        //{
        //    return s + " is a Valid string";
        //}
    }
}
