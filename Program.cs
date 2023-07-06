using System;

namespace ConsoleApp7_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Member = new Class1();
            Member.Age = 20;
            Console.WriteLine(Member.Age);
            


            Class1 Member2 = new Class1();
            //Member2.MemberName="Ali"//این پراپرتی چون رید انلی هست نمیشه بهش مقدار داد چون ست ندارد و مثل خط روبه رو ارور میدهد
            Console.WriteLine(Member2.MemberName);
            Member2.Age = 31;
            Console.WriteLine(Member2.Age);


        }
    }
}
