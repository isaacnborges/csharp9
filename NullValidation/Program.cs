using System;

namespace NullValidation
{
    //https://github.com/dotnet/csharplang/issues/2145

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ManipulateString(Name);
            //OtherManipulateString(Name);
        }

        //private string ManipulateString(string text!)
        //{
        //    return s + " is a Valid string";
        //}

        //public static string OtherManipulateString(string s!!)
        //{
        //    return s + " is a Valid string";
        //}
    }
}
