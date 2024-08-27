//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    internal class Class11
//    {
//        //반복문 : 프로그램에서 특정 조건이나 특정 횟수만큼 반복을 진행하기 위한 제어문
//        //for문 / while문

//        //while문 : 특정 조건을 만족하는 동안 계속 반복하는 설계에서 자주 사용됩니다.
//        //for문 : 특정 횟수만큼 반복하는 설계에서 자주 사용됩니다.
//        static void Main(string[] args)
//        {
//            //for문 사용하기
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine($"반복문이 {i + 1}번 실행 중입니다.");
//            }
//            //for문의 진행 순서
//            //1. int i = 0; 최초 1회 실행
//            //2. i < 10의 조건을 확인합니다.
//            //2-1. 조건이 맞을 경우 for문 내부에 설계한 명령을 실행합니다.
//            //2-2. i++를 진행합니다. ++는 값 하나를 1 증가시키는 증감 연산자입니다.
//            //     이 작업을 조건이 맞을 때까지 2-1 ~ 2-2를 계속 반복합니다.
//            //3. 조건이 더이상 맞지 않는다면 작업 종료

//            //1에서 100까지의 수의 합을 구하시오.
//            int hap = 0;
//            for (int i = 1; i <= 100; i++) //조건에 맞게 for문 설계
//            {
//                hap += i;
//            }
//            Console.WriteLine(hap);
//            //1에서 10까지의 수의 곱을 구하세요.
//            int gop = 1;
//            for (int i = 1; i <= 10; i++)
//            {
//                gop += i;
//            }
//            Console.WriteLine(gop);

//            //for문의 규칙
//            //1. for문에서 만들어진 int i는 for문 작업이 종료되면 사라집니다.
//            //2. 조건 생략 가능합니다. 이 경우는 무한 루프가 발생할 수 있습니다.(일반적으로는 사용하지 않습니다.)
//            //3. if문과 마찬가지로 for문 내부에서 for문을 작성하는게 가능합니다. 이 경우
//            //   첫 반복 시 내부의 for문이 전체 반복됩니다.

//            //2중 for문 사용해보기
//            for(int i = 2; i <= 9; i++)
//            {
//                for(int j = 1; j <= 9; j++)
//                {
//                    Console.WriteLine($"{i} X {j} = {i * j}");
//                }
//                Console.WriteLine(); //띄어쓰기
//            }

//            //위에서 작성한 구구단을 이용해 다음과 같은 조건의 내용을 출력합니다.
//            //1. 구구단 중에서 짝수 단만 출력해주세요.
            
//            //1) 초기식의 증가하는 부분을 수정해서 2개씩 증가하도록 설계
//            for (int i = 2; i <= 9; i+=2)
//            {
//                for (int j = 1; j <= 9; j++)
//                {
//                    Console.WriteLine($"{i} X {j} = {i * j}");
//                }
//                Console.WriteLine(); //띄어쓰기
//            }
//            //2. 문장 전체를 반복하면서 i가 짝수인 조건만 처리합니다.
//            for (int i = 2; i <= 9; i += 2)
//            {
//                if(i %2 == 0)
//                {
//                    for (int j = 1; j <= 9; j++)
//                    {
//                        Console.WriteLine($"{i} X {j} = {i * j}");
//                    }
//                    Console.WriteLine(); //띄어쓰기
//                }
//            }

//            //while문

//            bool isMove = false;

//            while(!isMove) //isMove가 true가 아닌 경우 반복 진행
//            {
//                Console.Write("움직이시겠습니까? y / n >> ");
//                string input = Console.ReadLine();  
//                if(input.ToLower() == "y") //input으로 입력받은 영단어가 소문자로 변경됩니다.
//                {
//                    isMove = true;
//                }
//                if (input.ToLower() == "n")
//                {
//                    isMove = false;
//                }
//            }
//            //문자열.ToLower() : 해당 문자열이 소문자로 변경됩니다.(영문자)
//            //문자열.ToUpper() : 해당 문자열이 대문자로 변경됩니다.(영문자)



//        }
//    }
//}
