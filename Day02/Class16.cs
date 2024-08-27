//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //열거형 enum
//    //값 중에서 순서대로 표현되는 것들을 편하게 이름붙여서 사용하는 개념
//    public enum DAY
//    {
//        월, 화, 수, 목, 금, 토, 일
//    }
//    public enum Position
//    {
//        ATTACK = 1, GUARD
//        //enum에 숫자를 적용하면 다음 값은 그 다음 숫자를 가지게 됩니다.
//    }
//    public enum Unit_Type
//    {
//        GOBLIN, SLIME, OAK
//    }
//    public enum Attack_Case
//    {
//        ATTACK, ATTACKED
//    }
//    internal class Class16
//    {
//        //소환을 한다.(유닛의 종류, 유닛의 자세, 이름)

//        static void Summon(Unit_Type type, Position p, string name)
//        {
//            Console.WriteLine($"{type} 몬스터 {name}이 소환되었습니다.");
//            //if (p == Position.ATTACK)
//            //{
//            //    Console.WriteLine($"{name}가 공격 자세를 취했습니다.");
//            //}
//            //else
//            //{
//            //    Console.WriteLine($"{name}가 방어 자세를 취했습니다.");
//            //}
//            //위의 문장을 switch로 설계하면 다음과 같습니다.
//            //enum 설계 시 선택지를 switch로 설계하면 코드를 보기가 좀 더 직관적입니다.
//            switch (p)
//            {
//                case Position.ATTACK:
//                    Console.WriteLine($"{name}가 공격 자세를 취했습니다."); break;
//                case Position.GUARD:
//                    Console.WriteLine($"{name}가 방어 자세를 취했습니다."); break;
//            }
//        }
//        static void Main(string[] args)
//        {
//            DAY day = DAY.수; //변수처럼 사용
//            //Console.WriteLine(DAY.월);
//            if (day == DAY.수)
//            {
//                Console.WriteLine("오늘이 이번주 마지막 수업입니다.");
//            }
//            Console.WriteLine($"{day} 요일은 DAY의 {(int)day}번째 순서의 데이터입니다.");
//            //일반적인 enum은 0부터 값이 순차적으로 만들어지기에 int 형태로 변형이 가능합니다.
//            // (자료형)변수/값을 통해 해당 자료형으로 변형이 가능합니다.(casting)
//            int select = 4;
//            Console.WriteLine($"우리가 선택한 요일은 {(DAY)select}입니다.");
//            string today = nameof(DAY.일);
//            Console.WriteLine(today);
//            //enum의 활용은 데이터의 변환을 얼마나 자유롭게 할 수 있는가에 달렸습니다.
//            Summon(Unit_Type.GOBLIN, Position.ATTACK, "고블린");
//            //문제) 사용자가 요일을 입력합니다.
//            //요일을 입력하면 해당 요일이 평일인지 평일이 아닌지 알려주는 함수를 구현해 화면에 출력하세요.
//            //힌트) 함수를 호출할 경우 결과가 출력됩니다.
//            isWeekdays(Console.ReadLine());
//        }
//        static void isWeekdays(string value)
//        {
//            if (value == nameof(DAY.토) || value == nameof(DAY.일))
//                Console.WriteLine("평일이 아닙니다.");
//            else
//                Console.WriteLine("평일입니다.");
//        }
//    }
//    a
//}
