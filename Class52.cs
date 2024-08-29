//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //2. 이벤트(Event)
//    //특수한 제약 조건이 추가된 delegate라고도 볼 수 있습니다.
//    //이벤트는 추가, 제거만 가능하며 할당은 불가능합니다.
//    //클래스 외부에서 이벤트를 직접 호출할 수 없습니다.

//    //이벤트 코드의 장점
//    //이벤트를 게시하는 게시자(Publisher)가 구독자(Subscriber)가
//    //해당 이벤트를 어떻게 처리할지 알 필요가 없습니다.
//    //구독자가 등록해놓은 함수들의 목록을 호출하기만 하면 됩니다.

//    //이벤트를 진행하는 구독자(Subscriber)는 게시자를 따로
//    //검사할 필요가 없습니다.

//    //이런 식으로 설계할 경우 다음과 같은 장점을 얻을 수 있습니다.
//    //1. 관계가 형성되면서 코드와 코드가 꼬일 수 있는 상황 방지

//    //2. 특정 원하는 상황 , 타이밍에 기능이 실행되는 것이기에
//    //   무분별하게 코드를 시간마다 호출하지 않아도 됨.(Unity의 Update문)


//    //이벤트를 동작시키기 위한 delegate(Event Handler)
//    public delegate void ThreeSixNine(string message);
//    public class Publisher //이벤트를 게시하는 역할을 가진 클래스
//    {
//        //이벤트 선언
//        //event delegate명 이벤트변수명;
//        public event ThreeSixNine TSN_Event;
//        public void Check(int number)
//        {
//            //해당 이벤트가 존재할 때 작업하도록 합니다.
//            if(TSN_Event != null)
//            {
//                //3 6 9 체크
//                if(number%10  == 3 || number % 10 == 6 || number % 10 == 9)
//                {
//                    TSN_Event("박수!");
//                }
//                else
//                {
//                    Console.WriteLine(number);
//                }
//            }
//        }
//    }
//    public class Subscriber //이벤트를 진행하는 클래스
//    {
//        public void TSNHandler(string message)
//        {
//            Console.WriteLine("[이벤트 발생!]");
//            Console.WriteLine($"{message}");
//        }
//        public void EventStart()
//        {
//            Publisher TSN = new Publisher();
//            TSN.TSN_Event += new ThreeSixNine(TSNHandler);
//            //이벤트 게시자가 가진 이벤트에 TSNHandler를 등록합니다.
            
//            //이벤트가 발생할 상황을 설계
//            for(int i = 0; i < 30; i++)
//            {
//                TSN.Check(i);
//            }
//        }
//    }

//    public delegate void ThousandUser(string message);
//    class VisitPublisher //개최자
//    {
//        public event ThousandUser TSNHandler;
//        public void Check(int visit_count)
//        {
//            //해당 이벤트가 존재할 때 작업하도록 합니다.
//            if (TSNHandler != null)
//            {
//                //3 6 9 체크
//                if (visit_count == 1000)
//                {
//                    TSNHandler("★★★★★이벤트에 당첨되셨습니다 1000번째 손님입니다.★★★★★");
//                }
//                else
//                {
//                    Console.WriteLine($"{visit_count}번째 손님 입장하셨습니다");
//                }
//            }
//        }
//    }
//    class BlogUser
//    {
//        int Count { get; set; }

//        public BlogUser(int count)
//        {
//            Count = count;
//        }

//        public void TSNHandler(string message)
//        {
//            Console.WriteLine($"{message}");
//        }

   
//        public void EventStart()
//        {
//            VisitPublisher TSN = new VisitPublisher();
//            ThousandUser thousandUser = TSNHandler;
//            TSN.TSNHandler += thousandUser;
//            TSN.Check(Count);
//        }
//    }



//    internal class Class52
//    {
//        //블로그에 접속할때마다 n번째 손님으로 등록됩니다.
//        //1000번째 손님일 때 이벤트 당첨을 알리고 축하 메세지를 보내려고 합니다.
//        //이벤트로 구현해주세요.


//        static void Main(string[] args)
//        {
//            Subscriber s = new Subscriber();
//            s.EventStart();

//            BlogUser blogUser = new BlogUser(1000);
//            blogUser.EventStart();
//        }
//    }
//}
