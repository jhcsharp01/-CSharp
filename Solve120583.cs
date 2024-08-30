//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////https://school.programmers.co.kr/learn/courses/30/lessons/120583

//namespace ConsoleApp1
//{
//    internal class Solve120583
//    {
//        public static int solution(int[] array, int n)
//        {
//            //배열 안에서 짝수인 요소의 개수를 찾아라.
//            //var count = array.Where()
//            int answer = 0;
//            for(int i = 0; i < array.Length; i++)
//            {
//                if(n == array[i])
//                    answer++;
//            }
//            return answer;
//        }

//        public static void Main(string[] args)
//        {
//            string result = string.Join(",", solution([2, 1, 3, 4, 1],1));
//            string result2 = string.Join(",", solution([0,2,3,4],1));
//            Console.WriteLine(result);
//            Console.WriteLine(result2);
//        }
//    }
//}
