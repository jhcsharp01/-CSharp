//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class2
//    {
//        static float data = 2.0f; //float(실수) 값을 적을 시 마지막에 f를 작성해줍니다.
//        //static(정적 변수) : 따로 개체를 생성하지 않고 변수나 함수를 사용하기 위해 static을 붙여줍니다.
//        int value = 10;
//        static void Main(string[] args)
//        {
//            //local(지역 변수) : 함수 내부에서 만들어진 변수
//            //                  함수 내부에서 생성되고, 함수가 종료되면 삭제됩니다.
//            //문자열
//            string menu = "김치찌개";
//            //문자
//            char alpha = 'A';
//            //논리형
//            bool isJump = true; //bool은 논리형(Boolean)
//            int money = 1000;
//            bool result = money > 1000; //식에 대한 결과 등도 bool로 저장 가능

//            Console.WriteLine(data); //Main 밖에서 만들어진 변수는 바로 사용하는 것이 불가능합니다.
//            Console.WriteLine(menu);
//            Console.WriteLine(alpha);
//            Console.WriteLine(isJump);
//            Console.WriteLine(money);
//            Console.WriteLine(result);
//            Class2 class_instance = new Class2(); //Class2 형태의 클래스 데이터를 생성합니다.
//            Console.WriteLine(class_instance.value);
//            //클래스 데이터를 만들면 그 데이터가 가지고 있는 변수 또는 함수를 사용할 수 있습니다.
//        }
//    }
//}
