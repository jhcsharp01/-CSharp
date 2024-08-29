//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //이벤트(Event)와 델리게이트(delegate)
//    //1. 델리게이트(delegate) : 대리자
//    //>> 메소드 참조

//    //사용 방법 : 본인이 참조할려고하는 메소드와 동일한 형태의 delegate 선언
//    //delegate 자료형 델리게이트명(매개변수명);
//    delegate int MyDelegate(int a, int b);
//    public class UserPlus
//    {
//        public static int coin = 0;
//        public static int point = 0;  
//        public static void CoinPlus(int value)
//        {
//            Console.WriteLine($"{value}만큼 적립을 성공했습니다.");
//            coin += value;
//        }
//        public static void PointPlus(int value)
//        {
//            Console.WriteLine($"{value}만큼 적립을 성공했습니다.");
//            point += value;
//        }
//    }

//    public delegate void DPlus(int coin_value, int point_value);
//    public class UserPlusDelegate
//    {
//        public static int coin = 0;
//        public static int point = 0;
//        public static void CoinPlus(int coin_value, int point_value)
//        {
//            Console.WriteLine($"{coin_value}만큼 적립을 성공했습니다.");
//            coin += coin_value;
//        }
//        public static void PointPlus(int coin_value, int point_value)
//        {
//            Console.WriteLine($"{point_value}만큼 적립을 성공했습니다.");
//            point += point_value;
//        }
//    }
//    internal class Class50
//    {
//        static int Add(int a, int b)
//        {
//             return a + b;
//        }
//        static int Min(int a, int b)
//        {
//            return a - b;
//        }

//        static void Main(string[] args)
//        {
//            //델리게이트 사용
//            //델리게이트명 델리게이트변수명 = 델리게이트로 처리하려는 함수의 이름; 
//            MyDelegate myDelegate = Add;
//            Console.WriteLine(myDelegate(1,5));
//            myDelegate = Min;
//            Console.WriteLine(myDelegate(1,5));
//            UserPlus.CoinPlus(50);
//            UserPlus.PointPlus(70);
//            //delegate를 통해 코인 플러스의 기능을 사용
//            DPlus userPlusDelegate = UserPlusDelegate.CoinPlus;
//            //delegate chain 진행(함수의 이름을 delegate에 + 또는 -를 통해
//            //기능을 추가하는 것이 가능합니다.)
//            userPlusDelegate += UserPlusDelegate.PointPlus;
//            userPlusDelegate(100, 780);
//            //한 번의 호출로 2개의 기능을 사용하는데 성공
//        }
//    }
//}
