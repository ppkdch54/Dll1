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
    };
    struct StructIplimage
    {
        public int id;
    };

    [StructLayout(LayoutKind.Sequential)]
    class Results
    {
        public int a;
        public int b;
        public Results()
        { }
    };

    [StructLayout(LayoutKind.Sequential)]
    struct AlarmInfo
    {
        public int framNo;
        public bool result;
    };
    class Program
    {
        [DllImport("Dll1.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern int testInputStruct(MyStruct myStruct);
        //[DllImport("Dll1.dll", CallingConvention = CallingConvention.Cdecl)]
        //static extern int testInputStructArray(MyStruct[] paraArray, int size);
        [DllImport("Dll1.dll", EntryPoint = "testOutPutStructArray", CallingConvention = CallingConvention.Cdecl)]
        static extern int testOutPutStructArray(IntPtr paraArray,int size);

        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct
            {
                id = 100,
                num = 88
            };
            MyStruct[] testStructArray = new MyStruct[] { myStruct, myStruct };
            //Console.WriteLine(testInputStruct(myStruct));
            //Console.WriteLine(testInputStructArray(testStructArray, testStructArray.Count()));

            AlarmInfo alarmInfo = new AlarmInfo
            {
                framNo = 50,
                result = true
            };
            AlarmInfo[] alarmInfoArray = new AlarmInfo[50];
            alarmInfoArray[0] = alarmInfo;

            //// 调用复杂结构体测试  
            int size = Marshal.SizeOf(typeof(Results)) * 50;
            byte[] bytes = new byte[size];
            IntPtr pBuff = Marshal.AllocHGlobal(size);
            testOutPutStructArray(pBuff, 50);
            Results[] pClass = new Results[50];
            for (int i = 0; i < 50; i++)
            {
                IntPtr ptr = new IntPtr(pBuff.ToInt64() + Marshal.SizeOf(typeof(Results)) * i);
                pClass[i] = (Results)Marshal.PtrToStructure(ptr, typeof(Results));
            }
            Marshal.FreeHGlobal(pBuff); // 释放内存  

            Console.ReadKey();
        }
    }
}
