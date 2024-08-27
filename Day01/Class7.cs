//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    //메뉴판 프로그램 설계
//    //화면에 메뉴와 메뉴의 가격이 표시가 됩니다.
//    //사용자는 메뉴의 이름 또는 메뉴의 번호를 입력해서
//    //그 번호에 맞는 메뉴를 구입하는 프로그램
//    internal class Class7
//    {
//        static void Main(string[] args)
//        {
//            //메뉴판은 같은 형태의 데이터가 연속되는 패턴
//            //따라서 같은 형태의 데이터를 묶어서 표현하는 배열을 통해 구현
//            //배열을 직접 만드는 방법
//            //자료형[] 배열명 = {요소1, 요소2, 요소3};

//            //[변수 생성]
//            string[] menus = {"일반 김밥", "참치 김밥", "돈까스 김밥"};
//            int[] prices = {3000, 3500, 4500};

//            //[메뉴판 출력]
//            Console.WriteLine($"1. {menus[0]}    {prices[0] : #,###} ￦");
//            Console.WriteLine($"2. {menus[1]}    {prices[1] : #,###} ￦");
//            Console.WriteLine($"3. {menus[2]}  {prices[2]:#,###} ￦");


//            //[번호 입력]
//            int number = int.Parse(Console.ReadLine());
//            //정수형 변수 number는 Console.ReadLine()을 통해 입력한 값을 int로 파싱해서
//            //나온 결과를 가지게 될 것입니다.
//            //[switch 문법 사용]
//            switch(number)
//            {
//                //case를 적으면 switch를 통해 작업할 변수가 저 값일 경우에 문법을 실행합니다.
//                //break 지점까지 작업을 계속 이어 나갑니다.
//                case 1:
//                case 2:
//                case 3:
//                    Console.WriteLine($"{menus[number-1]}를 구매했습니다.");
//                    break;
//            }

//        }
//    }
//}
