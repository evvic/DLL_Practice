using System;
using System.Runtime.InteropServices;

namespace Importing_DLL
{
    class Program
    {
        //path starts in the buried bin\Debug\netcoreapp3.1 folder, must change to correct directory.
        public const string dll_location = @"..\..\..\..\x64\Debug\ModularPractice.dll";

        [DllImport(dll_location,
            EntryPoint = "HelloWorld",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int HelloWorld();
        static void Main(string[] args)
        {
            int better = HelloWorld();
            Console.WriteLine("Hello World!");
            Console.WriteLine(better);
        }
    }
}
