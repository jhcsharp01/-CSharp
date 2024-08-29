//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Practice
//{
//    //풀이 1)
//    //4등인 "kai" 선수가 2번 추월하여 2등이 되고 앞서 3등, 2등인 "poe", "soe" 선수는 4등, 3등이 됩니다.

//    //선수의 이름을 통해 등수를 알 수 있습니다.

//    internal class Solve178871
//    {
//        public static string[] solution(string[] players, string[] callings)
//        {
//            //[강사 풀이]
//            //Dictionary<string, int> races = new Dictionary<string, int>();
//            ////선수의 이름과 등수를 통해 race를 딕셔너리 표현

//            ////플레이어의 이름을 순서대로 등록
//            //for(int i = 0; i < players.Length; i++)
//            //{
//            //    races.Add(players[i], i);
//            //    Console.WriteLine($"{players[i]} {i}");
//            //    // races[players[i]] = i;
//            //}

//            //[문제 풀이 팁]
//            //Select와 ToDictionary를 통해 딕셔너리 설정을 진행하는 코드
//            Dictionary<string, int> races = players.Select((s, i) => new { name = s, index = i })
//                .ToDictionary(d => d.name, d => d.index);

//            //선수 콜링만큼 작업을 진행합니다.
//            foreach (string player in callings)
//            {
//                //등수에 대한 데이터 생성
//                int rank = races[player];

//                //플레이어를 추월할 경우 위치가 1칸 바뀌게 됨.
//                string over_player = players[rank - 1];
//                //해당 위치에 추월한 선수를 적용합니다.
//                players[rank - 1] = player; //현재 플레이어 등록
//                players[rank] = over_player;//넘긴 플레이어 등록
//                Console.WriteLine($"[Calling!] {players[rank - 1]}");
//                //딕셔너리에 값 설정(경주 처리)
//                races[player] = rank - 1; //랭크 하락
//                races[over_player] = rank; //해당 랭크로 적용
//            }
//            return players;
//        }

//        static void Main(string[] args)
//        {
//            string result = string.Join(",",
//                solution(["mumu","soe","poe","kai","mine"], ["kai","kai","mine","mine"]));
//            Console.WriteLine(result);
//        }

//    }
//}
