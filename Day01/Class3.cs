//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class3
//    {
//        //C# 기본 입력 기능
//        //Console.ReadLine();
//        static void Main(string[] args)
//        {
//            Console.Write("이름을 입력해주세요 >> ");
//            //Write는 WriteLine에서 띄어쓰기의 기능인 Line이 제거된 문법
//            string name = Console.ReadLine();
//            Console.WriteLine(name);

//            Console.Write("나이를 입력해주세요 >> ");
//            string input = Console.ReadLine();
//            int age = int.Parse(input);
//            //int.Parse(문자열)은 문자열을 int 형태로 바꿔주는 기능
//            //단 이 때 형식에 맞지 않는다면 에러 발생
//            Console.WriteLine(age);
//            //한 줄에 여러 값을 입력받는 방법
//            Console.Write("영어 수학 점수를 순서대로 입력해주세요 >> ");
//            input = Console.ReadLine();
//            string[] scores = input.Split(" ");
//            //1. 자료형[]는 배열(array)를 의미하며, 같은 타입의 데이터를 여러 개 묶음으로
//            //   표현할 때 사용하는 자료구조입니다.
//            //2. 문자열.Split(" ") 해당 문자열을 공백을 기준으로 짜르는 기능
//            //1 2 3 4 5 입력 -> [1,2,3,4,5]

//            int eng = int.Parse(scores[0]); // 배열이름[인덱스 번호] = 배열의 묶음에서 해당 번째 데이터를 의미합니다.
//                                            // 따라서 scores[0]은 scores의 0번째 데이터
//                                            // 인덱스(index)는 순서를 가지고 있는 데이터 묶음에서 특정 데이터의 위치를 표현하는 정수형 데이터
//                                            // 특징으로는 0번부터 순서대로 번호를 가지게 됩니다.
//            int kor = int.Parse(scores[1]);
//            Console.WriteLine($"영어 점수 : {eng}점 수학 점수 : {kor} 점");
//            //Split 사용 시 띄어쓰기를 기준으로 나누기 때문에 두개 작성하는 상황에 하나만 작성할 경우 두번째 값이 공백으로 들어가는게
//            //아니라 그냥 없는 상태
//            //배열을 사용하는데 있어서 범위에 없는 값을 골랐을 경우 오류가 발생합니다.
//            //ex) 배열로 데이터를 3개 만들었는데 4번째 데이터 요구       
//        }
//    }
//}
