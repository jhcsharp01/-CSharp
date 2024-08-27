//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Practice
//{
//    interface Icounseler
//    {
//        void Next(); //상담을 진행하는 메소드
//        void Call(); //다음 순서 상담자에게 배분하는 기능
//    }
//    class RR : Icounseler
//    {
//        public void Call()
//        {
//            Console.WriteLine("대기열 순으로 상담을 진행하겠습니다....");
//        }

//        public void Next()
//        {
//            Console.WriteLine("다음 순서의 상담원을 연결해드리겠습니다.");
//        }
//    }
//    class LW : Icounseler
//    {
//        public void Call()
//        {
//            Console.WriteLine("현재 대기중인 열 중 가장 짧은 대기열로 이동해드리겠습니다..");
//        }

//        public void Next()
//        {
//            Console.WriteLine("대기열이 변경되었고 차례가 되면 상담원을 연결해드리겠습니다.");
            
//        }
//    }
//    class PA : Icounseler
//    {
//        public void Call()
//        {
//            Console.WriteLine("고객 등급에 따라 상담을 진행하도록 하겠습니다.");
//            Console.WriteLine("현재 등급은 X 등급입니다.");
//        }

//        public void Next()
//        {
//            Console.WriteLine("상담원을 연결해드리겠습니다.");
//        }
//    }

//    //위의 인터페이스를 통해 다음과 같은 클래스를 구현합니다.
//    //1. 모든 상담원이 들어오는 전화 순서대로 상담을 처리하는 class RR
//    //2. 가장 짧은 대기열 쪽을 찾아 상담을 처리하는 class LW
//    //3. 고객 등급에 따라 상담을 처리하는 class PA


//    internal class Class42
//    {
//        static void Main()
//        {
//            while(true)
//            {
//                Console.WriteLine("상담원입니다. 어떤 상담을 진행하시겠습니까?");
//                Console.WriteLine("RR : 순차적으로 진행합니다.");
//                Console.WriteLine("LW : 가장 짧은 대기열로 이동합니다.");
//                Console.WriteLine("PA : 고객 등급에 따라 진행합니다.");

//                string input = Console.ReadLine();
//                Icounseler icounseler = null;
//                //입력한 단어에 따라 인터페이스를 관련 자식 클래스로 생성합니다.
//                //인터페이스명 변수명 = new 자식클래스명();
//                if (input == "RR")
//                {
//                    icounseler = new RR();
//                }
//                else if (input == "LW")
//                {
//                    icounseler = new LW();
//                }
//                else if (input == "PA")
//                {
//                    icounseler = new PA();
//                }

//                //선택한 클래스에 따라 실행 결과가 달라집니다.
//                icounseler.Next();
//                icounseler.Call();
//                //인터페이스를 통한 클래스 구현을 통해 동일한 이름의 메소드를 사용할 수 있으며
//                //이는 불필요한 코드 설계를 막는데도 효과적입니다.
//            }
//        }
//    }
//}
