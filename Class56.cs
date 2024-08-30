//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Engine
//    {
//        public string Name { get; set; } //엔진의 이름
//        public int Cost { get; set; } //파워를 내기 위한 분당 비용
//        public int Power { get; set; } //파워
//        public Engine(string name, int cost, int power)
//        {
//            Name = name;
//            Cost = cost;
//            Power = power;
//        }
//    }
//    internal class Class56
//    {
//        //보유 엔진 표
//        //람다N 50C 150P
//        //델타N 45C 167P
//        //시그마N 32C 78P
//        //유니티N 82C 372P
//        //알파N 70C 150P
//        static void Main(string[] args)
//        {
//            //엔진 중 효율이 좋은 데이터를 하나 추출하시오.
//            List<Engine> list = new List<Engine>()
//            { 
//                new Engine("람다",40,150),
//                new Engine("델타",45,167),
//                new Engine("시그마",32,78),
//                new Engine("유니티",82,372),
//                new Engine("알파",70,150),
//            };
//            //파워 / 비용 수치가 가장 큰 값
//            //가장 큰 값이 맨 위로 가야하니까 Descending
//            //효율을 데이터로 만드는 방법
//            var Best = list.Select(engine => new
//            {
//                Engine = engine, //엔진은 엔진
//                EngineName = engine.Name, //다른 데이터 남길 경우 넣어주기
//                Eff = engine.Power / engine.Cost
//            }).OrderByDescending(engine => engine.Eff).ToList();

//            foreach(var engine in Best)
//            {
//                Console.WriteLine($"이름 : {engine.EngineName} 효율 : {engine.Eff}");
//            }

//            //정렬을 한 후 효율을 따로 출력
//            var result = list.OrderByDescending(engine => (double)engine.Power / engine.Cost).ToList();
//            foreach (var engine in result)
//            {
//                Console.WriteLine($"{engine.Name} : {engine.Power / engine.Cost:F2}");
//            }
//            //하나의 데이터만 뽑아보자.
//            //위에서 데이터를 추출했으니 기준 중에서 가장 큰 값을 데이터로 담는다.
//        }

//    }
//}
