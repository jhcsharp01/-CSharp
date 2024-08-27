//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    //스택(stack)
//    //한쪽 방향으로 데이터를 쌓는 자료구조
//    //특징) 제일 위에만 데이터를 쌓을 수 있습니다.
//    //후입선출(Last-in First-out) : 마지막에 넣은 값이 우선적으로 제거되는 방식
//    internal class Class32
//    {
//        //스택 관련 공부
//        //1. 배열 등을 이용해서 스택의 기능을 직접 구현해본다.
//        static void Main(string[] args)
//        {
//            //스택 생성 방법
//            Stack<int> stack = new Stack<int>();
//            //데이터 추가 기능 Push
//            for(int i = 0; i < 10; i++)
//            {
//                stack.Push(i+1);
//            }
//            //데이터 사용/제거 기능 Pop();
//            while (stack.Count > 0) //스택의 개수 표현
//            {
//                //데이터 맨 앞의 값을 return하고 스택에서 제거합니다.
//                Console.WriteLine(stack.Pop());
//            }
//            //데이터 맨 위의 값 표현 Peek  
//            //데이터 조사 Contains
//        }
//    }
//}
