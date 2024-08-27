//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //재귀함수(Recursive Function)
//    //함수 내부에서 자기 자신을 반복하는 형태의 설계
//    //특징) 반드시 종료 조건이 존재하도록 설계합니다.(아닐 경우 Stack Overflow 현상 발생)
//    //      호출 중에 호출이 진행되므로, 호출 종료 시점에 남아있는 값들이 처리되는 방식
//    //      스택에서 보관할 수 있는 수치를 넘으면 오류 발생(Stack Overflow)
//    //      반복문 코드 없이 반복적인 결과에 대한 설계가 가능합니다.
//    //      특정 알고리즘 구현 시 설계가 편하다는 장점
//    //      함수를 계속 호출하는 행위이기에 같은 결과라면 일반 반복문이 더 성능적으로 좋습니다.
//    internal class Class20
//    {
//        //1. 팩토리얼(factorial)
//        //숫자!로 표현을 하며, 이는 1부터 숫자까지의 곱을 의미합니다.
//        //ex) 5! = 1*2*3*4*5 = 120
//        //    N! = N * (N-1) * ... *  1(반복 종료)
//        static int Factorial(int number)
//        {
//            //1. 이 작업이 종료되는 조건을 작성합니다.
//            if (number == 1)
//                return 1;
//            //2. 반복되고 있는 형태를 return에 작성합니다.
//            return number * Factorial(number - 1);
//        }
        
//        //최대 공약수(Greatest Common Divisor)
//        //※ 두 수의 곱을 최대 공약수로 나누면 최소 공배수가 된다.
//        static int gcd(int M, int N)
//        {
//            //사용자가 M과 N을 (M > N)로 안넣었을 경우 대비
//            if( M < N)
//            {
//                //값 교환(swap)
//                int temp = M; //하나를 저장
//                M = N; //다른 값으로 초기화
//                N = temp; //남은 값은 저장해둔 값으로 초기화
//            }
//            //종료 조건 (M과 N을 나누고 남은 값이 0이라면 그때의 N이 최대공약수 입니다.) 
//            if( M % N == 0)
//            {
//                return N;
//            }
//            return gcd(N, M % N); //gcd를 호출해서 기존의 N을 M의 위치로, M%N한 결과를 N 자리에 전달
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Factorial(5));
//            //★★★ 코드 실행 순서
//            //F(5) 호출
//            // 5 * F(4)
//            //       4  * F(3)
//            //              3  * F(2)
//            //                      2 * F(1)
//            //                            1 (호출 종료)
//            //return  5 * 4 * 3* 2 * 1
//            Console.WriteLine(gcd(12345, 1234));
//        }
//    }
//}
