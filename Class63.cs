using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class63
    {
        //dynamic
        //런타임에서 데이터의 형식을 정할 수 있습니다.
        //var처럼 데이터 타입이 나중에 정해지는 키워드인데
        //var의 경우는 컴파일할 때 데이터의 형식이 결정이 되고
        //dynamic의 경우는 런타임 환경에서 결정됩니다.
        //이런 dynamic은 외부에서 데이터를 받아 작업하는 통신 작업 등에 매우 유리한 형식입니다.
        static void Main(string[] args)
        {
       
            dynamic data;
            data = 1234;
            Console.WriteLine(data);
            Console.WriteLine(data.GetType());//dynamic을 사용하는 경우 visual studio에서
            //추천 코드를 알려주는 인텔리 기능을 사용할 수 없습니다.

            data = "Change!";
            Console.WriteLine(data);
            Console.WriteLine(data.GetType());

            data = 3.14f;
            Console.WriteLine(data);
            Console.WriteLine(data.GetType());
        }
    }

}
