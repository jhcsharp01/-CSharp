//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Practice
//{
//    internal class Solve68644
//    {
//        public static int[] solution(int[] numbers)
//        {
//            List<int> answer = new List<int>();

//            //1. 배열에 대한 반복문을 출력합니다.
//            for(int i = 0; i < numbers.Length-1; i++)
//            {
//                Console.WriteLine($"{i+1}회 반복 시작");
//                //2. 두번째 수에 대한 반복을 진행합니다.
//                //시작 값 : 현재 i값보다 1칸 더 많게
//                for(int j = i+1; j < numbers.Length; j++)
//                {
//                    int temp = numbers[i] + numbers[j]; //두 수의 합
//                    Console.WriteLine($"numbers[i] = {numbers[i]} numbers[j] = {numbers[j]} temp ={temp}");
//                    //리스트 내에 두 수의 합이 없다면
//                    if(answer.Contains(temp) == false)
//                    {
//                        answer.Add(temp); //리스트에 해당 값을 더하시오.
//                        Console.WriteLine($"{temp}가 리스트에 추가되었습니다!");
//                    }
//                }
//            }
//            //클래스 사용 시에는 클래스 필드 값을 기준으로 정렬 가능 list.OrderBy(x => x.age).ToList();
//            //리스트에 대한 추가가 다 끝났기 때문에 리스트를 정렬
//            answer.Sort();
//            //List<int> ascend_answer = answer.OrderBy(x => x).ToList();
//            //OrderBy를 통해 오름차순 구현
//            //List<int> desend_answer = answer.OrderByDescending(x => x).ToList();
//            //OrderBy를 활용해 내림차순 구현
//            //answer.Sort(new Comparison<int>((x,y) => y.CompareTo(x)));
//            //Sort 안에 잇는 비교의 순서를 반대로 변경하는 코드
//            return answer.ToArray();
//        }
//        static void Main(string[] args)
//        {
//            //Visual Studio에서 출력 화면을 보기 위한 코드
//            //문제를 풀고 답을 제출하기 위한 용도라면 위의 함수만 구현
//            string result = string.Join(",", solution([2,1,3,4,1]));
//            //[2,3,4,5,6,7]
//            //1. 2 -> 3,5,6,3
//            //2. 1 -> 3,4,5,2
//            //3. 3 -> 5,4,7,4
//            //4. 4 -> 6,5,7,5
//            //5. 1 -> 3,4,5,2
//            //중복 제거 ) 2,3,5,6,7,4
//            //오름 차순 ) 2,3,4,5,6,7

//            Console.WriteLine(result);
//        }
//    }
//}
