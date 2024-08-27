//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;
////using을 통해 프로그램에 기능을 추가할 수 있습니다.

////변수(variable) 74p
////하나의 데이터를 저장하기 위해 사용자가 이름을 할당한 저장 공간

////변수 만드는 방법
////1. 변수 선언 -> 자료형 변수명; ex) int money;
////2. 변수의 초기화(initialize) -> 변수에 값을 대입하는 것
////    변수명 = 값;  ex) money = 1000;
////  위의 두 작업은 동시에 진행이 가능합니다. int money =  1000;
 
////자료형은 변수를 선언할 때 최초 1회 작성합니다.
////변수의 이름 길이 제한이 따로 없습니다. 단 사용에 불편하게 길게 적을 필요는 없습니다.
////변수의 이름 맨 앞에는 숫자가 나올 수 없습니다.
////변수의 이름에서 특수 문자를 사용할 수 없습니다. 단 예외가 존재하긴 합니다. (_)
////변수의 값을 초기화할 때, 자료형에 맞는 값을 넣어줘야 합니다.
//float one = 10;

////자료형(Type)
////프로그램이 데이터를 판단하는 기준

////자료형 종류(자주 사용되는)
////정수 int (4 byte)  실수 float (4 byte)  문자 char (1 byte) 문자열  string  논리형 boolean (true or false) (1 byte)
//namespace ConsoleApp1
//{
//    internal class Class1
//    {
//        static void Main(string[] args)
//        {
//            //돈 1000원에 대한 표현을 진행합니다.
//            //1. 이 데이터의 유형(type)은? 정수(int)
//            //2. 변수의 이름은? money
//            //3. 변수가 가지고 있을 값(수치)? 1000 
//            int money = 1000;//세미콜론(;)은 작업이 마무리 됬음을 알리는 기호
//            Console.WriteLine(money);
//            Console.WriteLine("현재 가지고 있는 돈은 {0}원입니다.", money);
//            Console.WriteLine($"현재 가지고 있는 돈은 {money}원입니다.");
//            Console.WriteLine($"현재 가지고 있는 돈은 {money:#,###}원입니다.");
//        }//블록(block) 프로그램 작업 범위(scope)

//    }
//}
