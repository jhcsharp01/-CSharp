//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //컬렉션(Collection : Queue)
//    //특징 : 선입선출(First-in ,First-out : FIFO)로 데이터를 관리합니다.
//    //       먼저 들어온 데이터가 먼저 빠져나가게 되는 구조

//    //다이얼로그 같은 기능 구현 시 사용하면 효과적임.

//    internal class Class31
//    {
//        static void Main(string[] args)
//        {
//            //1. 생성 방법
//           Queue<string> queue = new Queue<string>();

//            //2. 데이터 추가(Euqueue)
//            queue.Enqueue("one");
//            queue.Enqueue("two");
//            queue.Enqueue("three");
//            queue.Enqueue("four");
//            queue.Enqueue("five");

//            Console.WriteLine("=== 큐 ===");
//            foreach (var item in queue)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("==========");
//            Console.WriteLine("현재 큐의 개수 : " + queue.Count);
            
//            //3.데이터 제거(Dequeue)
//            Console.WriteLine(queue.Dequeue() +"를 큐에서 제거했습니다.");
//            Console.WriteLine("=== 큐 ===");
//            foreach (var item in queue)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("==========");
//            Console.WriteLine("현재 큐의 개수 : " + queue.Count);

//            //4. 맨 앞의 데이터 표현
//            Console.WriteLine(queue.Peek());
//            Console.WriteLine("현재 큐의 개수 : " + queue.Count);

//            //5.  큐에 해당 데이터가 있는지 조사
//            if(queue.Contains("two"))
//            {
//                Console.WriteLine("two가 큐에 존재합니다.");
//            }

//            //6. 큐에 있는 값을 배열화
//            string[] elements = queue.ToArray();
//            foreach (var element in elements)
//            {
//                Console.WriteLine(element);
//            }

//        }
//    }
//}
