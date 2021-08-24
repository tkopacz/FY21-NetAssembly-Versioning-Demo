using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAsm = typeof(Program).Assembly;
            Console.WriteLine("---Begin");
            Console.WriteLine($"Assembly: {myAsm.GetName().Name}, {myAsm.GetName().Version}");
            Console.WriteLine("-----------------------------------");
            //dotnet tool install -g nbgv
            Console.WriteLine($"ThisAssembly.AssemblyVersion: {ThisAssembly.AssemblyVersion}");
            Console.WriteLine($"ThisAssembly.AssemblyFileVersion: {ThisAssembly.AssemblyFileVersion}");
            Console.WriteLine($"ThisAssembly.AssemblyInformationalVersion: {ThisAssembly.AssemblyInformationalVersion}");
            Console.WriteLine($"ThisAssembly.AssemblyName: {ThisAssembly.AssemblyName}");
            //Console.WriteLine($"{ThisAssembly.PublicKey}");
            //Console.WriteLine($"{ThisAssembly.PublicKeyToken}");
            Console.WriteLine($"ThisAssembly.AssemblyTitle: {ThisAssembly.AssemblyTitle}");
            Console.WriteLine($"ThisAssembly.AssemblyConfiguration: {ThisAssembly.AssemblyConfiguration}");
            Console.WriteLine($"ThisAssembly.RootNamespace: {ThisAssembly.RootNamespace}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Attributes:");
            foreach (var item in myAsm.CustomAttributes)
            {
                Console.WriteLine($"{item.AttributeType.Name}");
                if (item.ConstructorArguments.Count > 0) Console.WriteLine("  ConstructorArguments");
                foreach (var i1 in item.ConstructorArguments)
                {
                    Console.WriteLine($"   > {i1.Value}");
                }
                if (item.NamedArguments.Count>0) Console.WriteLine("  NamedArguments");
                foreach (var i2 in item.NamedArguments)
                {
                    Console.WriteLine($"   > {i2.MemberName}:{i2.TypedValue.Value}");
                }
            }
            Console.WriteLine("End---\r\nEnter\r\n");
            Console.ReadLine();
        }
    }
}