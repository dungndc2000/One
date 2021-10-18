using System;
using System.Text;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World!");
            int year;

            Console.WriteLine("Nhập vào năm cần xem:");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Năm âm lịch là :  {0} {1}",(Enum.EnumClass)(year%10),(Enum.EnumClas)(year%12));
        }
    }
}
