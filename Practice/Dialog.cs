//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //대화 다이얼로그를 구현해봅시다.

//    //대화용 스크립트를 설계해 Queue에 저장합니다.
//    //순서대로 대화를 진행시킵니다.
//    //대화가 끝나면 프로그램 종료

//    //과제 1) 대화를 다음으로 넘기거나 이전으로 돌리는 기능을 추가하세요.(C#)

//    //과제 2) 대화 다이얼로그를 기반으로 퀘스트 다이얼로그 구현해보기 (C#)
//    //퀘스트의 예시
//    //퀘스트를 받기 전의 대화와 퀘스트를 받은 후의 대화가 다르게 진행되는 경우
//    internal class Dialog
//    {
//        static void Main(string[] args)
//        {
//            //다이얼로그 생성
//            Queue<string> dialogs = new Queue<string>();

//            //다이얼로그 내용 추가
//            dialogs.Enqueue("안녕하십니까 좋은 아침입니다.");
//            dialogs.Enqueue("저는 모닝 커피를 마시려 갈겁니다.");
//            dialogs.Enqueue("커피를 마시면 머리가 맑아집니다.");
//            dialogs.Enqueue("단 매일 마시면 머리가 안 맑아집니다.");
//            dialogs.Enqueue("2일에 1번씩 먹는걸로...");

//            //다이얼로그의 개수가 0이 되면 멈추게
//            while (dialogs.Count > 0)
//            {
//                //맨 위에 있는 데이터(문장)의 길이만큼 반복
//                for (int i = 0; i < dialogs.Peek().Length; i++)
//                {
//                    //단어 하나하나를 출력
//                    Console.Write(dialogs.Peek()[i]);
//                    //초당 발음을 연출하기 위해 Sleep(밀리초)
//                    Thread.Sleep(50);
//                }
//                Console.WriteLine();//한 문장 당 띄어쓰기 진행
//                //Console.Clear(); //한 문장 당 화면 지우기 
//                dialogs.Dequeue(); //맨 위의 데이터를 내보내기
//            }

//        }
//    }
//}
