//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class18
//    {
//        //제어문 / 반복문 관련 문법들
//        static void Main(string[] args)
//        {
//            //1. continue
//            //반복문에서 continue 사용 시 다음 반복 차례로 넘기는 기능
//            for (int i = 1; i <= 100; i++)
//            {
//                if(i % 2 == 0)
//                {
//                    continue;
//                    Console.WriteLine("컨티뉴 아래는 작업 안합니다.");
//                }
//                Console.Write(i + " ");
//            }
//            //위의 코드를 실행하면 1부터 100까지의 수 중 홀수에 해당하는 값만 출력됩니다.
//            //if로 홀수를 걸러내는게 아닌 짝수를 작업하지 않는 방식의 설계
//            //2. break
//            //반복문에서 break 사용 시 작업을 중단하는 기능
//            for (int i = 1; i <= 100; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    break;
//                    Console.WriteLine("컨티뉴 아래는 작업 안합니다.");
//                }
//                Console.Write(i + " ");
//            }
//            //3. while(true)
//            //조건식이 true이기 때문에 항상 조건을 만족하는 무한루프 문입니다.
//            //break를 통해 탈출할 상황을 만들어 주는 것이 좋습니다.
//            while(true)
//            {
//                Console.Write("종료하고 싶으면 화면에 종료를 입력해주세요 >>");
//                string input = Console.ReadLine();

//                if(input == "종료")
//                {
//                    break;
//                }
//                Console.Clear(); //화면 지우기
//            }
//            //4. do - while
//            int number;
//            int hap = 0;
//            //do-while
//            //do 안에 설계된 코드를 무조건 1회 실행시킵니다.
//            //그 후에 while문을 통해 조건식을 체크하고, 조건 여부에 따라 반복을 처리합니다.
//            //프로그램 설계를 진행하다보면 반복 작업에서 무조건 1회는 실행시켜야 자연스러운
//            //코드들 설계 시 do-while로 설계하면 자연스러운 설계가 가능합니다.
//            do
//            {
//                Console.Write("0을 입력하면 작업을 종료합니다.");
//                number = int.Parse(Console.ReadLine());
//                hap += number;
//                Console.WriteLine($"현재까지 입력한 숫자의 합 = {hap}");
//            } while (number != 0);
//        }
//    }
//}
