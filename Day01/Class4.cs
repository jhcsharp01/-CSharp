//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    internal class Class4
//    {
//        static void Main(string[] args)
//        {
//            bool isDead = false;
//            //만약에 isDead가 true라면, "YOU DIE"를 화면에 출력하겠습니다.
//            if (isDead == true)
//            {
//                Console.WriteLine("YOU DIE");
//            }
//            // a == b는 a와 b의 값의 크기가 같은지를 판단합니다.
//            #region if문
//            //if문은 조건을 작성한 후, 그 조건이 성립한다면 if문 내부에 설계한
//            //명령문을 실행하는 제어문입니다.

//            //if문을 사용하기 위해서 조건을 세워야하는데 이 조건을 만들기 위해서는
//            //변수가 필요합니다. 조건을 위해 만들어준 변수를 초기식이라고 부릅니다.

//            //if문의 설계를 위해 조건을 세울 때 사용하는 연산자를 알고 있어야 합니다.
//            // a > b, a < b , a >= b , a <= b : 초과 미만 이상 이하
//            // a == b a와 b가 값이 같습니다.
//            // a != b a와 b가 값이 서로 다릅니다.

//            //if문 사용 방법
//            //1. 일반 if문
//            //if(조건식)
//            //{
//            //    조건식의 결과가 만족했을 때(true), 실행할 명령문;
//            //}

//            //2. if - else문
//            //if(조건식)
//            //{
//            //    ...
//            //}
//            //else
//            //{
//            //    위에 작성한 if문의 결과가 만족하지 않앗을 때(false), 실행할 명령문;
//            //}

//            //3. if - else if - else
//            //if (조건식)
//            //{
//            //    ...
//            //}
//            //else if(조건식2)
//            //{
//            //    조건식이 만족하지 않고, 조건식2가 만족했을 경우 실행할 명령문;
//            //}
//            //else
//            //{
//            //    위에 있는 모든 if, else if의 조건이 만족하지 않았을 경우 실행할 명령문;
//            //}
//            #endregion
//            //1. 사이다 2. 콜라 3. 환타를 고르는 코드
//            int select = 1;
//            if (select == 1)
//                Console.WriteLine("사이다를 먹겠습니다.");
//            //if문 다음에 명령이 1개일 경우에는 {}를 지워도 됩니다.
//            else if (select == 2)
//                Console.WriteLine("콜라를 먹겠습니다.");
//            else if (select == 3)
//                Console.WriteLine("환타를 먹겠습니다.");

//            //조건 2개 이상 사용하는 if문
//            //1부터 10까지의 범위까지 입력받는 코드
//            Console.Write("1 ~ 10 사이의 숫자를 입력해주세요 >> ");
//            string input = Console.ReadLine();
//            int number = int.Parse(input);

//            //1. 조건 하나 체크하고 다음 조건 체크하러 가기
//            //이 경우 else의 설계가 중복될 수 있는 상황이 생길 수 있습니다.
//            if (number >= 1)
//            {
//                if (number <= 10)
//                {
//                    Console.WriteLine("작업 완료");
//                }
//                else
//                {
//                    Console.WriteLine("범위 내의 숫자가 아닙니다.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("범위 내의 숫자가 아닙니다.");
//            }

//            //2. 조건식을 여러 개 작성해서 작업을 진행합니다.
//            //   A && B : 조건식 A와 조건식 B의 조건이 모두 일치하는 경우 true
//            //   A || B : 조건식 A나 조건식 B 중 하나라도 일치하면 true
//            //   !A : 조건식 A의 결과를 반대로 처리합니다.
//            if (number >= 1 && number <= 10)
//            {
//                Console.WriteLine("작업 완료");
//            }
//            else
//            {
//                Console.WriteLine("범위 내의 숫자가 아닙니다.");
//            }
//        }

//    }
//}
//s