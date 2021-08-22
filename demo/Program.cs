using System;
using System.Reflection;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAsm = typeof(Program).Assembly;

            Console.WriteLine("Begin");
            //Display(0,$"{myAsm}")
            //System.Console.WriteLine(myAsm.FullName, myAsm.Version);
            myAsm.CustomAttributes;
            DisplayAttributes(.GetCustomAttribute());
            Console.WriteLine("End");
        }

        public static void DisplayAttributes(Int32 indent, MemberInfo mi)
        {
            // Get the set of custom attributes; if none exist, just return.
            object[] attrs = mi.GetCustomAttributes(false);
            if (attrs.Length == 0) { return; }
            DisplayAttributes(indent,attrs);
        }

        public static void DisplayAttributes(Int32 indent, object[] attrs)
        {
            // Get the set of custom attributes; if none exist, just return.
            object[] attrs = mi.GetCustomAttributes(false);

            // Display the custom attributes applied to this member.
            Display(indent + 1, "Attributes:");
            foreach (object o in attrs)
            {
                Display(indent + 2, "{0}", o.ToString());
            }
        }
        // Display a formatted string indented by the specified amount.
        public static void Display(Int32 indent, string format, params object[] param)

        {
            Console.Write(new string(' ', indent * 2));
            Console.WriteLine(format, param);
        }
    }
}
