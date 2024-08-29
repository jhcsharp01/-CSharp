//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Practice
//{
//    internal class Solve12918
//    {
//        public static bool solution(string s)
//        {
//            //길이 제한 처리
//            if (s.Length == 4 || s.Length == 6)
//                return int.TryParse(s, out int result); //변환 가능 여부 판단 TryParse
//            return false;//일반적인 경우라면 false
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine(solution("a234"));
//            Console.WriteLine(solution("1234"));          
//        }
//    }
//}
