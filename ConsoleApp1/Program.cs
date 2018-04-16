using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct MyStruct
    {
        public int num;
        public int id;
    }
    class Program
    {
        [DllImport("Dll1.dll",CallingConvention = CallingConvention.Cdecl,CharSet = CharSet.Ansi)]
        static extern int testDll(MyStruct myStruct);

        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct
            {
                id = 9,
                num = 88
            };
            Console.WriteLine(testDll(myStruct));
            Console.ReadKey();
        }
    }
}
