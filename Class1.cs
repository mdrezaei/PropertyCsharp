using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_Property
{
    class Class1
    {
        private int _age;
        // public int Age {get; set;}
        public int Age//این یک پراپرتی است زیرا گت ست دارد. میتونیم به شکل زیر بازش کنیم یا میتونیم بدون مقدار دادن و کدنوشتن برای گت ست اش استفاده اش کنیم مانند بالا 
        {//میتوانیم ست ان را هم برداریم و فقط گت داشته باشد در این صورت  فقط رید انلی هست یعنی فقط قابلیت خواندن دارد
            //private int _age;//اشتباه است
            get
            {
                return _age;
            }
            set//ست بجز اینکه مقدار میگیره و عملیات اجرا میکنه اگر دستوری نیاز به اجرا و نشون دادن ریزالت داشته باشه قبل از گت ، نشونش میده چون به هر حال باید عملیات رو اجراکنه عملیات هم کد هست دیگه
            {
                if (value > 30)
                {
                    Console.WriteLine($"{value} is unaceptable. maximom age is");
                    this._age = 30;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string MemberName //یک پراپرتی رید انلی
        {
            get 
            {
                return "Gholi";
            }
        }
    }
}
