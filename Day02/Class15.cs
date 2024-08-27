//using System;

//namespace ConsoleApp1
//{
//    internal class Class15
//    { 
//        // return 함수를 만드는 방법
//        //return할 자료형 함수명(매개변수)
//        //{
//        //  실행할 명령문;
//        //  return 값;
//        //}
//        static int Add(int a , int b)
//        {
//            return a + b;
//        }
//        const float PI = 3.14f;
//        //const 자료형 변수명 = 값;
//        //const는 프로그램 코드에서 사용할 상수를 표현하기 위한 키워드입니다.
//        //한번 만들어진 값은 수정할 수 없습니다.
//        //이 값은 프로그램 전체에서 해당 값 대신 사용할 수 있습니다.(static 사용 x)    

//        static float Area(int radius)
//        {
//            return 2 * radius * PI;
//        }
//        //float와 double?
//        //float와 double은 둘다 실수를 표현하는 자료형
//        //float 같은 경우는 약 소수점 6자리정도까지 정확하게 계산되는 정도
//        //double 같은 경우는 약 15자리정도까지는 정확하게 계산이 되는 정도

//        //double을 사용할 경우 3.14같은 값에 f를 붙일 필요가 없습니다.
//        //f는 해당 값이 float임을 알리는 표시      
//        static void Main(string[] args)
//        {
//            //값 2개를 넣어주면, 그 값의 합을 계산하는 함수를 만들어서
//            //프로그램에서 사용해보겠습니다.
//            Console.WriteLine(Add(10,5));
//            Console.WriteLine(Add(20,18));
//            Console.WriteLine(PI);

//            //반지름을 넣어주면, 원의 둘레를 계산해주는 함수
//            //※ 원주율은 3.14로 사용합니다.
//            Console.WriteLine($"{Area(10):N2}");
//            //N2는 소수점 두 자리 까지 표현하라는 표기법입니다.

//            //※ c#에서 소수점을 작업할 때 사용되는 함수
//            double d = 2.48;
//            double round_d = Math.Round(d);
//            double ceil_d = Math.Ceiling(d);
//            double truncate_d = Math.Truncate(d);

//            Console.WriteLine($"d = {d}");
//            Console.WriteLine($"round_d = {round_d}"); //반올림
//            Console.WriteLine($"ceil_d = {ceil_d}");   //올림
//            Console.WriteLine($"truncate_d = {truncate_d}"); //내림

//            round_d = Math.Round(d, 1); //round(값, 자리수) : 해당 자리수를 기준으로 반올림
//            //Math.Round(double a)와 Math.Round(double value, int digits)는
//            //함수의 이름은 동일하나 매개변수의 개수, 순서가 다르게 설계된 함수들입니다.
//            //이 경우 함수의 이름이 같아도, 중복이 아닌 다른 기능으로써 판단합니다.(overloading)
//            Console.WriteLine($"round_d = {round_d}");
//        }
//    }
//}
