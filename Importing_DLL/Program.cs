using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Importing_DLL
{
    class Program
    {
        //path starts in the buried bin\Debug\netcoreapp3.1 folder, must change to correct directory.
        public const string dll_location = @"..\..\..\..\x64\Debug\ModularPractice.dll";

        
        [DllImport(dll_location,
            EntryPoint = "HelloWorld",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr HelloWorld();
        

        [DllImport(dll_location,
            EntryPoint = "Calculate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int Calculate(int one, int two);

        [DllImport(dll_location,
            EntryPoint = "GetString",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetString(StringBuilder str, int strlen);

        const int STRING_MAX_LENGTH = 80;

        static void Main(string[] args)
        {
            //c++ .dll prints to console
            HelloWorld();

            //c++ .dll performs operation from arguments and returns result
            int better = Calculate(6, 6);
            Console.WriteLine($"calculating = {better}");
            Console.WriteLine("Hello World!");

            //retrieving a string from a c++ .dll
            StringBuilder str = new StringBuilder(STRING_MAX_LENGTH);
            GetString(str, STRING_MAX_LENGTH);
            Console.WriteLine(str);
        }
    }
}
