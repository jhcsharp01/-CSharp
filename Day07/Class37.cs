//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //throw : Exception 객체를 전달하는 기능
//    internal class Class37
//    {
//        static int Divide(int a, int b)
//        {
//            if ( b == 0)
//            {
//                throw new Exception("0으로 나눌 수는 없습니다.");
//                //throw new Exception("메세지");
//                //를 통해 예외를 생성해 던집니다.
//            }
//            return a / b;
//        }

//        static void SendMessage(string message)
//        {
//            if(message == null)
//            {
//                throw new Exception("메세지를 적어주세요.");
//            }
//        }
//        //해당 방식을 통해 특정 조건, 상황 자체를 예외 상황으로 두고 처리하게 설계할 수 있습니다.
//        //코드의 흐름을 설계하기가 쉬워집니다.

//        static void Main(string[] args)
//        {
//            try
//            {
//                //Console.WriteLine(Divide(10, 0));
//                SendMessage(null);
//            }
//            catch(Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }

//    }
//}
