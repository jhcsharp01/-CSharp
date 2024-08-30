//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //c#에서 제공해주는 대리자
//    //1.Func<T> : 최대 16개의 매개변수를 가질 수 있는 대리자
//    //            반환 값을 반드시 요구하는 대리자
//    //2.Action :  반환 값이 따로 없는 특정 작업만을 진행하기 위한 대리자

//    //무명 메소드 & delegate
//    //무명 메소드 : 메소드를 미리 정의하지 않아도 되는 메소드 명이 없는 메소드
//    //             지속적으로 필요한게 아닌 일회용으로 필요한 기능을 대상으로 
//    //             사용되며 별도의 메소드를 정의하지 않아도 되는게 장점

    
//    internal class Class57
//    {
//        //[델리게이트 예제]
//        public delegate int Mydelegate(int a, int b);
//        public static int Add(int a, int b) => a + b;
//        public static void UseDelegate(int a, int b, string oper , Mydelegate mdelegate)
//            => Console.WriteLine($"{a} {oper} {b} = {mdelegate(a, b)}");
//        //[Func, Action 사용]
//        static int getData() => 25;
//        static int getData2() => 26;
//        static void Main(string[] args)
//        {
//        //Func<타입, 매개변수..> func명 = (매개변수) => 작업할 내용;
//            Func<int> func1 = () => 10;
//            //int 타입의 Func이면서 매개변수 int
//            Func<int, int> func2 = (x) => x * 2;
//            Console.WriteLine(func2(5));

//            //일반적인 delegate 형태처럼 등록해서 사용 가능
//            Func<int> func3 = getData;
//            func3 += getData2; //delegate chain도 가능
//            Console.WriteLine($"{func3()}");

//            //Action<매개변수..> action명 = (매개변수) => {작업할 내용 구현};
//            int result = 0;
//            Action<int> action01 = (x) => result = x * 10;
//            action01(10);
//            Console.WriteLine(result);

//            //일반적으로는 delegate를 통해 일반 함수든 return 함수든 다 구현이 가능
//            //하지만 상황에 따라 return을 요구하는 경우나 아닌 경우가 존재하며
//            //delegate를 활용해 매개변수로 함수 자체가 들어가는 경우에 잘못된 데이터가
//            //들어감을 방지해줍니다.

//            Mydelegate mydelegate = Add;
//            UseDelegate(10, 5, "+", mydelegate);
//            UseDelegate(10, 5, "-", (x, y) => x - y);
//            //delegate의 형태에 맞는 식을 직접 넣어서 실행 가능
//            UseDelegate(10, 5, "-", Add);
//            //delegate에 맞는 함수를 넣어서도 사용 가능

//        }

//    }
//}
