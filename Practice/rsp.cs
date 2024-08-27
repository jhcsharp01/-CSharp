//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class rsp
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();

//            string[] rsp = { "가위", "바위", "보" };
//            int[] scores = { 0, 0, 0 }; //승 무 패
//            bool isRight = false; //입력을 제대로 했는지에 대한 변수

//            for(int i = 1; i <= 10; i++)
//            {
//                Console.Write($"[{i}번째 실행] 가위 바위 보! >> ");
//                string input = Console.ReadLine();
//                //입력한 값이 가위 바위 보가 아니라면?
//                //>> 입력한 값과 rsp 전체의 값을 비교합니다
//                for(int j = 0; j < rsp.Length; j++) //배열명.Length는 배열이 가진 데이터의 개수(길이)
//                {
//                    if (input == rsp[j]) //rsp의 j번째 값이 입력한 값과 같다면
//                    {
//                        isRight = true;
//                        break; //작업 중단, 답이 나온 상태에서 남은 반복을 작업하지 않기 위해 작성
//                    }
//                }
//               if(isRight) //bool 타입의 변수를 조건문에 그대로 적을 경우 해당 값이 true면 성립합니다.
//               {
//                    //상대방에 대한 작업
//                    string other = rsp[random.Next(rsp.Length)]; // 0 ~ 2

//                    //경기 판정에 대한 변수(플레이어 기준)
//                    string result = "";

//                    //결과에 대한 공식 세우기
//                    if (input == other)
//                    {
//                        result = "무승부";
//                    }
//                    else
//                    {
//                        // "가위", "바위", "보"
//                        if (input == rsp[0]) 
//                        {
//                            if (other == rsp[1])
//                                result = "패배";
//                            else
//                                result = "승리";
//                        }
//                        else if (input == rsp[1])
//                        {
//                            if (other == rsp[2])
//                                result = "패배";
//                            else
//                                result = "승리";
//                        }
//                        else
//                        {
//                            if (other == rsp[0])
//                                result = "패배";
//                            else
//                                result = "승리";
//                        }
//                    }
//                    //결과에 따른 점수 처리
//                    switch(result)
//                    {
//                        case "승리":
//                            scores[0]++;
//                            break;
//                        case "무승부" :
//                            scores[1]++;
//                            break;
//                        case "패배":
//                            scores[2]++;
//                            break;
//                    }
//                    //결과 출력
//                    Console.WriteLine($"플레이어 {input} 상대 {other} 결과 : {result}");
//               }
//                else //isRight가 false인 경우(가위 바위 보중에 없는 단어를 입력한 경우)
//                {
//                    Console.WriteLine("잘못된 입력입니다.");
//                    i--; //시작 값을 1 감소시킵니다.
//                         //반복이 끝날때마다  i가 증가하게 되니
//                         //같은 구간을 다시 반복하게 될 것입니다.
//                }
//                isRight = false;//조건 reset
//            }

//            // for문이 종료되었을 경우
//            Console.WriteLine($"{scores[0]} 승 {scores[1]} 무 {scores[2]} 패");
//        }

        


//    }
//}
