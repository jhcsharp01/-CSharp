//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    //딕셔너리(Dictinary)
//    //Key : Value의 한 묶음으로 관리되는 자료구조
//    //Key의 경우는 Value에 접근하기 위한 값
//    //Value는 Key로 얻을 수 있는 값
//    //Key는 딕셔너리 내에서 중복된 값을 가질 수 없습니다.
//    //Key의 이름이 딕셔너리의 인덱스로 사용됩니다.
//    //Value는 딕셔너리 내에서 중복된 값을 가질 수 있습니다.
//    //Key를 삭제할 경우 Value도 같이 삭제됩니다.
//    internal class Example08
//    {
//        static void Main(string[] args)
//        {
//            //1. 딕셔너리 만들기
//            //  Dictionary<TKey, Tvalue> 딕셔너리명 = new Dictionary<TKey, Tvalue>();
//            // 각 위치에는 키와 값에 해당하는 자료형을 작성합니다.
//            Dictionary<string, int> skill_books = new Dictionary<string, int>();
//            //TKey ?  string
//            //TValue ? int

//            //2. 딕셔너리 추가
//            //Add(K,V)를 이용한 추가
//            skill_books.Add("두번 베기", 2);
//            //딕셔너리명[K] = V;를 이용한 추가
//            skill_books["삼단 베기"] = 3;

//            //3. KeyValuePair<TKey,TValue>
//            //키/값의 쌍을 검색할 수 있게 도움을 주는 데이터
//            foreach (KeyValuePair<string, int> skill in skill_books)
//            {
//                Console.WriteLine($"key = {skill.Key} value = {skill.Value}");
//            }
//            //var로 표현해 쓰는 경우가 더 많습니다.
//            foreach (var skill in skill_books)
//            {
//                Console.WriteLine($"key = {skill.Key} value = {skill.Value}");
//            }

//            //4. 값 수정
//            Console.WriteLine("삼단 베기의 공격력이 1 증가했습니다!");
//            //해당 키가 이미 존재한다면 그 키가 가지고 있는 값에 적용됩니다.
//            skill_books["삼단 베기"] = 4;

//            foreach (var skill in skill_books)
//            {
//                Console.WriteLine($"key = {skill.Key} value = {skill.Value}");
//            }
//            Console.WriteLine("두번 베기를 스킬북에서 제거합니다.");
//            skill_books.Remove("두번 베기");
//            foreach (var skill in skill_books)
//            {
//                Console.WriteLine($"key = {skill.Key} value = {skill.Value}");
//            }
//            //제거 방식(내용물을 확인하는 방식)
//            //Remove 동작을 if문으로 설계하면 상황을 알 수 있음.
//            //내부의 값에 대한 표현은 out을 통해 진행할 수 있습니다.
//            if(skill_books.Remove("두번 베기", out int value))
//            {
//                Console.WriteLine($"두번 베기를 삭제했습니다.(Value = {value})");
//            }
//            else
//            {
//                Console.WriteLine($"두번 베기는 스킬북에 존재하지 않습니다.");
//            }
//            //요소 추가(중복 데이터 확인)
//            //키가 존재한다면 else 안내문
//            //키가 없다면 if 안내문
//            if(skill_books.TryAdd("사단 베기",4))
//            {
//                Console.WriteLine("사단 베기를 획득하셨습니다!");
//                Console.WriteLine("스킬명 : 사단 베기");
//                Console.WriteLine($"데미지 : {skill_books["사단 베기"]}");
//            }
//            else
//            {
//                Console.WriteLine("이미 해당 스킬을 가지고 있습니다.");
//            }
//            //데이터 가져오기(데이터 검색)
//            Console.Write("스킬 데이터를 조사합니다. 스킬을 입력해주세요 >> ");
//            string searching = Console.ReadLine();
//            if(skill_books.TryGetValue(searching, out int result))
//            {
//                Console.WriteLine($"해당 {searching}은 가지고 있습니다.");
//            }
//            else
//            {
//                Console.WriteLine($"해당 {searching}이 없습니다.");
//            }
//        }
//    }
//}
