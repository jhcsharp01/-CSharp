//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Solution42586
//    {
//        //[93,30,55] -> [2,1]
//        //배열의 결과 개수가 다름 ==> 리스트 같은 컬렉션으로 접근하면 편하다.
//        public static int[] solution(int[] progresses, int[] speeds)
//        {
//            //리스트 설계(작업의 횟수를 저장할 결과물)
//            List<int> answer = new List<int>();
//            int idx = 0; //인덱스 값(반복의 조건)
//            while(idx < progresses.Length)//배열 길이보다 작은 동안 반복(인덱스는 배열의 길이 -1까지)
//            {
//                int count = 1; //카운트를 1로 시작, (매 반복마다 초기화되서 리셋)

//                //1바퀴 돌리기
//                for(int i = idx;  i < progresses.Length; i++)
//                {
//                    progresses[i] += speeds[i];
//                    // 93+1 , 30 +30 , 55 + 5
//                }
//                //작업 최대치를 넘으면 카운트
//                if (progresses[idx] >= 100)
//                {
//                    //다음 값이 100%이 넘는 경우에 대한 체크
//                    for(int j = idx + 1; j < progresses.Length; j++)
//                    {
//                        if (progresses[j] >= 100)
//                        {
//                            idx = j;
//                            count++;
//                        }
//                        else
//                        {
//                            break;
//                        }
//                    }
//                    //인덱스 추가
//                    idx++;
//                    answer.Add(count); //계산이 끝난 값을 리스트에 넣어줍니다.
//                }     
//            }
//            //작업 완료 후 결과 내보내기
//            return answer.ToArray();
//        }
       
//        public static int[] solutionQueue(int[] progresses, int[] speeds)
//        {
//            List<int> answer = new List<int>();
//            Queue<int> day_queue = new Queue<int>();
//            //각 기능이 완료되는 날짜를 저장
            
//            //int day = 0; //진행 되는 날
//            //int dayNext = 0;//다음 날

//            //작업 시간을 큐로 저장합니다.
//            for(int i = 0; i < progresses.Length; i++)
//            {
//                //day = (100 - progresses[i]) / speeds[i];           
//                //if((100 - progresses[i]) % speeds[i] != 0)
//                //{
//                //  day++;
//                //}

//                //일정 = (int)올림((float)(100 - 작업된 시간) / 작업 속도)
//                int day = (int)Math.Ceiling(
//                    (float)(100 - progresses[i]) / speeds[i]
//                    );
//                //Math.Ceiling() : 올림
//                //Math.Truncate() : 버림
//                //Math.Round() : 반올림
//                day_queue.Enqueue(day);
//            }
//            while (day_queue.Count > 0)
//            {
//                int count = 1; //시작 카운트 설정
//                int day = day_queue.Dequeue(); //값 하나 받아오고 값 제거
//                while (day_queue.Count > 0)
//                {
//                    if(day >= day_queue.Peek())
//                    {
//                        day_queue.Dequeue();
//                        count++;
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }
//                answer.Add(count);
//            }
//            return answer.ToArray();
//        }

//        public static void Main(string[] args)
//        {
//            string result = string.Join(",", solution([93, 30, 55], [1, 30, 5]));
//            Console.WriteLine(result);
//            string resultQ = string.Join(",", solutionQueue([95, 90, 99,99,80,99], [1]));
//            Console.WriteLine(resultQ);
//        }
//    }
//}
