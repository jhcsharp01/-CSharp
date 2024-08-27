//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Practice
//{
//    class Person
//    {
//        public string name;
//        public int age;
//    }

//    internal class Class43
//    {
//        //리스트 사용하기 + LINQ
//        //(LINQ = Language-Integrated Query)
//        // C#에서 쿼리 언어를 사용할 수 있는 기술
//        // 배열이나 컬렉션 ,XML 파일 ,Dataset 등 묶음의 데이터에서 사용하는 문법 체계

//        static void Main(string[] args)
//        {
//            //Console.WriteLine(Calculate.Calculator.Add(1, 2));

//            //1) 배열 생성
//            string[] string_datas = {"Apple","Banana","Candy","Dawn","Elegance","Fire","Gate"};

//            //해당 데이터에서 원하는 값을 추출
//            //문자가 대문자 "A"로 시작하는 데이터를 추출
//            var result = from string_data in string_datas
//                         where string_data.StartsWith("A")
//                         select string_data;

//            foreach(var data in result)
//            {
//                Console.WriteLine(data);
//            }
//            //링크 장점
//            //1. SQL에 익숙하신 분들은 데이터의 접근을 더 쉽게 진행할 수 있습니다.
//            //2. 일반적인 반복문, 조건문을 세워서 특정 데이터를 찾는 것보다 코드가 단순하게 설계 됨.

//            //링크 단점
//            //1. SQL 기반의 RDBMS 활용을 안해본 사람에게는 어려움.
//            //2. 복잡한 쿼리 작업까지는 진행되지 않습니다.

//            //관련 문법
//            //1. from : 어떤 데이터로부터 어떤 값을 추출할 것인지
//            //2. where : 원하는 값을 추출하기 위한 조건 
//            //3. select : 데이터 중에서 어떤 항목

//            //링크 기반의 쿼리문은 from으로 시작해서 select로 끝납니다.

//            List<Person> person_list = new List<Person>()
//            {
//                //new 생성자() {필드 = 값}
//                new Person() { name = "Haru", age = 20 },
//                new Person() { name = "Zzangu", age =39},
//                new Person() { name = "Jake", age = 17}
//            };

//            //다음과 같은 조건으로 데이터를 추출해주세요.
//            //1. 나이는 35세 이하인 사람을 추출합니다.

//            var person_result = from person in person_list
//                                where person.age <= 35
//                                select person.name;
            
//            foreach(var person_name in person_result)
//            {
//                Console.WriteLine(person_name);
//            }

//            person_result = from person in person_list
//                            where person.name.EndsWith("u")
//                            select person.name;

//            foreach (var person_name in person_result)
//            {
//                Console.WriteLine(person_name);
//            }
//            var person_result2 = from person in person_list
//                                 where person.age >= 17
//                                 orderby person.age ascending //정렬
//                                 select person;
//            //ascending : 오름차순
//            //descending : 내림차순
//            foreach (var p in person_result2)
//            {
//                Console.WriteLine($"이름 :  {p.name} | 나이 {p.age}");
//            }

//            person_result2 = from person in person_list
//                             where person.age >= 17
//                             orderby person.age descending //정렬
//                             select person;
//            //ascending : 오름차순
//            //descending : 내림차순
//            foreach (var p in person_result2)
//            {
//                Console.WriteLine($"이름 :  {p.name} | 나이 {p.age}");
//            }
//        }
//    }
//}
