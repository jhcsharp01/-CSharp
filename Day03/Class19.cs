//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class19
//    {
//        static void Main(string[] args)
//        {
//            다음과 같은 출력 예시를 코드로 구현하세요.
//            조건) 보기에 해당하는 값이 아닐 경우에는 기능 선택: X
//            파일 열기 1
//            파일 저장 2
//            어플 종료 3
//            입력 >> 1
//            기능 선택 : 파일 열기
//            파일 열기 1
//            파일 저장 2
//            어플 종료 3
//            입력 >> 3
//            기능 선택 : 종료
//            int i; //입력
//            string[] results = { "파일 열기", "파일 저장", "어플 종료" }; //배열(결과)
//            int idx = 0; //인덱스
//            do
//            {
//                Console.WriteLine("파일 열기  1");
//                Console.WriteLine("파일 저장  2");
//                Console.WriteLine("어플 종료  3");

//                i = int.Parse(Console.ReadLine());
//                idx = i - 1;

//                if (i < 0 || i > 3)
//                {
//                    Console.WriteLine("기능 선택 : X");
//                    i = 1;
//                    continue;
//                }
//                else
//                {
//                    Console.WriteLine("기능 선택 : " + results[idx]);
//                }

//            } while (i > 0 && i < 3);
//            i가 0보다 작으면 종료
//            i가 3보다 크면 종료

//           위의 코드는 while (true) 로 설계하는게 더 편해보입니다.

//            while (true)
//            {
//                Console.WriteLine("파일 열기  1");
//                Console.WriteLine("파일 저장  2");
//                Console.WriteLine("어플 종료  3");
//                i = int.Parse(Console.ReadLine());

//                if (i < 0 || i > 3)
//                {
//                    Console.WriteLine("기능 선택 : X");
//                }
//                else if (i == 1)
//                {
//                    Console.WriteLine("기능 선택 : 파일 열기");
//                }
//                else if (i == 2)
//                {
//                    Console.WriteLine("기능 선택 : 파일 저장");
//                }
//                else if (i == 3)
//                {
//                    Console.WriteLine("기능 선택 : 어플 종료");
//                    break;
//                }
//            }



//            1부터 입력받은 수 N까지의 수 중에서 3의 배수를 제외한 수의 합을
//            구하는 프로그램을 작성하시오.
//            T / C
//            4
//            7

//            10
//            37
//            int N = int.Parse(Console.ReadLine());
//            int hap = 0;
//            for (int j = 1; j <= N; j++) //N만큼 반복
//            {
//                if (j % 3 == 0)//3의 배수일 경우 건너뜀
//                {
//                    continue;
//                }
//                hap += j; //일반적인 작업일 경우 더하기가 진행gi
//            }
//            Console.WriteLine($"합 = {hap}");
//        }
//    }
//}
