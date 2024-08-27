//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class22
//    {
//        //1. 피보나치 수열
//        //1 2 3 5 8 13 21 ....
//        //a b c
//        //a + b = c
//        //Fibo(5)를 실행하면 8이 출력되는 코드를 설계합니다.

//        //풀이 : return 값을 통해 규칙을 찾아내기
//        //F(1) = 1
//        //F(2) = 2
//        //F(3) = 3
//        //F(4) = 5
//        //F(5) = 8
//        //F(5) =F(4) + F(3);
//        // >> F(N) = F(N-1) + F(N-2);
//        static int Fibo(int n)
//        {
//            //종료 조건
//            if (n <= 1)
//                return 1;
//            return Fibo(n-1) + Fibo(n-2); //일반적인 식 작성
//        }
//        //2. 하노이의 타워
//        static void Hanoi(int Discs, string tower1, string tower2 , string tower3)
//        {
//            //디스크가 1개일 경우
//            if(Discs == 1)
//            {
//                Console.WriteLine($"원반 이동 경로 : {tower1} ->{tower3}");
//            }
//            else //옮겨야하는 경우
//            {
//                //원반 1개 사용해서 이동
//                Hanoi(Discs - 1, tower1, tower3, tower2);
//                //출력
//                Console.WriteLine($"원반 이동 경로 : {tower1} ->{tower3}");
//                //원반 1개 더 사용해서 보낸 지점에서 중앙으로 넘기는 작업 한번
//                Hanoi(Discs - 1, tower2, tower1, tower3);
//            }
//        }
//        //  A -> C
//        //  A -> B
//        //  C -> B
//        //  A -> C
//        //  B -> A
//        //  B -> C
//        //  A -> C
//        static void Main(string[] args)
//        {
//            //for(int i = 1; i <=10; i++)
//            //{
//            //    Console.Write(Fibo(i) + " ");
//            //}
//            Hanoi(4, "A", "B", "C");
//        }
//    }
//}
