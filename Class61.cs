//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //리플렉션(refelction)
//    //특성 정보를 얻거나 특정 형식을 로드해서 사용하도록 하는 도구
//    //특성(Attribute)
//    internal class Class61
//    {
//        class Test
//        {
//            public static void Tester() { }
//        }

//        public class Book
//        {
//            public string Name { get; set; }
//            public string publisherName { get; set; } = "시공사"; //프로퍼티 선언 뒤에 = 값; 적으면 적용
//            public string description { get; set; }
//            public override string? ToString()
//            {
//                return $"|{Name}|{publisherName}|{description}|"; 
//            }
//        }
//        static void Main(string[] args)
//        {
//            //1. Type 클래스 : 개체의 정보 중 타입에 해당하는 값을 얻을 수 있습니다.
//            string r = "Reflection";
//            Type t = r.GetType();
//            Console.WriteLine(t);

//            //어셈블리 클래스는 개체의 어셈블리 정보를 얻어올 수 있는 클래스입니다.
//            //c#에서 어셈블리는 컴파일을 통해 나온 결과 파일을 의미합니다.
//            //c#의 어셈블리는 중간 언어(exe, dll) 형태들의 집합
//            //어셈블리 내에서 각각의 클래스를 구분하는 기준 == 네임스페이스
//            System.Reflection.Assembly assembly = typeof(System.Random).Assembly;
//            Console.WriteLine(assembly);


//            Type t1 = typeof(Test); //Test 데이터 타입을 얻어옵니다.

//            //멤버 중에서 Static 또는 public으로 바인딩 되어있는 것들을 얻어옵니다.
//            //바인딩 플래그는 해당 객체의 조건을 의미합니다.
//            //바인딩 플래그 종류
//            //Default           0       바인딩 플래그를 별도로 지정하지 않습니다.
//            //IgnoreCase        1       이름의 대소문자를 구분하지 않겠습니다.
//            //DeclaredOnly      2       계층 수준에 맞는 멤버만 포함시킵니다.
//            //Instance          4       인스턴스 멤버를 포함시킵니다.
//            //Static            8       static 멤버를 포함시킵니다.
//            //Public            16      public 멤버를 포함시킵니다.
//            //NonPublic         32      public이 아닌 멤버를 포함시킵니다.

//            //MemberInfo : 멤버 조사
//            //FieldInfo : 필드 조사
//            MemberInfo[] members = t1.GetMembers(BindingFlags.Static | BindingFlags.Public);

//            foreach (MemberInfo member in members)
//            {
//                Console.WriteLine(member.Name);
//            }
//            Book book = new Book() { Name = "분노 설계자들", description = "미디어의 자극적인 컨텐츠와 가짜 뉴스에 대한 내용" };
//            var t2 = book.GetType();

//            PropertyInfo prop01 = t2.GetProperty("Name");
//            PropertyInfo prop02 = t2.GetProperty("description");
//            MethodInfo metho01 = t2.GetMethod("ToString");

//            //프로그램에서 사용할 동적 개체 생성
//            dynamic dy01 = new Book() {Name = "a", description = "asdasd" };
//            Console.WriteLine(dy01.publisherName);
//            Console.WriteLine(dy01.Name);
//            Console.WriteLine(dy01.description);      
//        }
//    }
//}
