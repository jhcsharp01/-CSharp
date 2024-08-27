//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    //연산자(operator) : 프로그램에서 연산을 진행할 때 사용하는 기호
//    //ex) 10 + 5 
//    //연산자 ?  + 
//    //피연산자 : 연산을 당하는 대상 10, 5
//    //연산을 진행할 때 사용되는 식, 값 -> 항
//    internal class Class9
//    {
//        // ctrl + d : 줄 복사
//        // alt + 화살표 위 아래 : 코드 위치 이동
//        // ctrl + a : 전체 선택
//        // ctrl + / : 주석 기능
//        // ctrl + shift + / : 주석 해제 기능
//        // ctrl + shift + a : 새 코드 만들기
//        // ctrl + F5 : 디버깅 없이 코드 실행

//        static void Main(string[] args)
//        {
//            int a = 1;
//            int b = 2;
//            int c = 3;
//            int d = 4;
//            //산술
//            //종류 : + , -, *(곱하기) , /(나누기), % (나머지)
//            //사칙 연산의 규칙과 동일한 우선순위를 가지고 있습니다
//            //곱하기 , 나누기 ,나머지 계산 우선, 더하기 , 빼기 순서
//            //괄호가 있다면 그 부분을 우선으로 계산합니다.
//            Console.WriteLine(a + b);
//            Console.WriteLine(a - b);
//            Console.WriteLine(c * a - d);
//            Console.WriteLine(b / (c - d));
//            Console.WriteLine(d % b);
//            //연산 유의 사항
//            int Max = int.MaxValue; //MaxValue는 int로 표현할 수 있는 가장 큰 값입니다.
//            Console.WriteLine(Max);
//            Max *= 4; //Max에 2를 곱합니다.
//            Console.WriteLine(Max); //최대치를 넘는 값에 대한 계산은 정확하게 되지 않습니다.
//            int e = 10;
//            //Console.WriteLine(e / 0); //0으로는 나눌 수가 없습니다. divide by zero
//            //오류가 나는 문장이기 때문에 이 문장은 주석으로 막아주세요.

//            //대입 연산자
//            //1. a = b  : a에 b의 값을 대입합니다.(초기화)          
//            //2. 복합 대입 연산 : 산술 연산자 + 대입 연산자
//            //   a += b : a에 b를 더한 결과를 a에 대입합니다. -> a에 b를 더하세요.
//            //   a -= b , a *= b , a /= b , a %= b
//            // %를 사용하는 경우
//            //1. 짝수, 홀수 개념을 설명할 때
//            int number;
//            number = int.Parse(Console.ReadLine());
//            //짝수 : 2로 나누었을 때 정확하게 나눠지는 값 -> 값이 2로 나누었을 때 남는 값은 0이다.
//            if(number %2 == 0)
//            {
//                Console.WriteLine("짝수입니다.");
//            }
//            else
//            {
//                Console.WriteLine("홀수입니다.");
//            }
//            //2. n의 배수에 대한 표현
//            //ex) 2의 배수는 2,4,6,8,10....
//            //    2로 나누었을 때 나머지가 0으로 나옴.
//            int value = 15;
//            if (value % 3 == 0)
//                Console.WriteLine("3의 배수");
//            else
//                Console.WriteLine("3의 배수가 아닙니다.");
//            //c#의 삼항 연산
//            //자료형 변수명 = 조건 ? 조건이 만족할 때 사용할 값: 조건이 만족하지 않을 때 사용할 값;
//            //if - else처럼 답이 둘 중 하나로 결정되는 식을 대신해서 사용할 수 있습니다.
//            string result = value % 3 == 0 ? "3의 배수" : "3의 배수가 아닙니다.";
//            Console.WriteLine(result);
//        }

//    }
//}
