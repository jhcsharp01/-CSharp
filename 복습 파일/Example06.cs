//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    //1교시 : 리스트(List)
//    //배열과 마찬가지로 데이터를 순서대로 저장한 자료구조
//    //리스트의 경우 추가, 삭제, 삽입 등의 기능을 제공하면서 동적으로 크기를 조절할 수 있습니다.
//    //List<T>의 형태로 구성이 되어있으며 T에는 자료형을 선언해줍니다.
//    internal class Example06
//    {
//        static void Main(string[] args)
//        {
//            //1. 리스트 생성 방법
//            //List<T> 리스트명 = new List<T>();
//            List<int> list = new List<int>();
//            //2. 리스트에 요소를 추가합니다.
//            list.Add(1);
//            //list.Add(1.5f); //T에 의해 int 이외의 값은 추가가 불가능합니다.
//            list.Add(2);
//            list.Add(7);
//            //3. 리스트의 내용 출력(인덱스 활용)
//            //인덱스 사용법 : 배열/리스트명[인덱스 번호]
//            Console.WriteLine(list[0]); 
//            //4. 리스트의 내용 출력(foreach문 활용)
//            foreach(int i in list)
//            {
//                Console.WriteLine(i);
//            }
//            //5. 리스트에 내용 추가(원하는 위치에) -> 삽입(Insert)
//            list.Insert(2, 17);
//            foreach (int i in list)
//            {
//                Console.WriteLine(i);
//            }
//            //6. 리스트 생성과 초기화
//            List<string> fruits = new List<string>(new string[]
//            {
//                "apple",
//                "banana",
//                "calamansi",
//            });
//            string data = "banana";
//            //Contains를 통해 검색
//            if(fruits.Contains(data))
//            {
//                Console.WriteLine(data);
//            }
//            //조건문을 통해 특정 값 조사
//            foreach (string s in fruits)
//            {            
//                if(s.StartsWith('a'))
//                    Console.WriteLine(s); 
//            }
//            //LINQ를 통한 조사
//            var search_data = from fruit in fruits  //작업 위치
//                              where fruit.EndsWith("i") //조건
//                              select fruit; //뽑아낼 값
//            foreach(var result in search_data)
//            {
//                Console.WriteLine(result);
//            }
//            //데이터 삭제
//            fruits.Remove("calamansi");
//            foreach (string s in fruits)
//            {  
//                Console.WriteLine(s);
//            }
//            //인덱스를 통해 삭제
//            fruits.RemoveAt(0); 
//            foreach (string s in fruits)
//            {
//                Console.WriteLine(s);
//            }
//            //데이터 전체 삭제
//            fruits.Clear();
//            //리스트의 갯수를 통해 리스트가 비어잇음을 표현
//            if(fruits.Count == 0)
//            {
//                Console.WriteLine("현재 보유한 과일 목록이 없습니다.");
//            }
//        }
//    }
//}
