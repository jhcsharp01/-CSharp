//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    //특성
//    //프로퍼티
//    //인덱서
    
//    /// <summary>
//    /// 프로퍼티 예제
//    /// </summary>
//    class Sample
//    {
//        //프로퍼티(Property) : 속성
//        //필드에 대한 보조로 사용하기도 하고 프로퍼티 그대로 사용하는 경우도 존재합니다.
//        #region Field   
//        //1. 프로퍼티로 표현할 필드 값을 만들어줍니다.
//        private string name;
//        private int age;
//        #endregion

//        #region Property
//        //2. 프로퍼티에 대한 설계를 진행합니다.
//        //프로퍼티의 이름은 필드 앞글자를 대문자로 변형해서 만드는 경우가 일반적입니다.
//        public string Name
//        {
//            get
//            {
//                return name; //프로퍼티를 사용하면 필드인 name을 return하게 됩니다.
//            }
//            set
//            {
//                //조건문을 통해 특정 상황을 작업할 수 있습니다.
//                if(value.Length > 7)
//                {
//                    Console.WriteLine("이름은 7자 이상 사용할 수 없습니다.");
//                }
//                else
//                    name = value; //name은 수정할 값(value)로 초기화됩니다.
//            }
//        }

//        public int Age
//        {
//            get
//            {
//                return age;
//            }
//            set
//            {
//                if (age <= 0)
//                {
//                    Console.WriteLine($"나이는 1살부터 측정 가능합니다!");
//                }
//                age = value;
//            }
//        }
//        #endregion
//        //장점 : 필드에 대한 작업을 메소드로 따로 만들 필요 없이, 변수처럼 값 대입을 통해 작업이 가능합니다.
//        //1. 캡슐화 구현 : 멤버 변수에 대한 접근을 막는 역할(필드가 아닌 프로퍼티로 접근 가능)
//        //2. 값에 대한 유효성 검사를 추가할 수 있습니다.
//        //3. 코드를 더 읽기 쉽게 만들어주고, 수정도 더 편합니다.
//    }

//    //인덱서는 클래스나 구조체의 객체를 배열처럼 접근하게 도와주는 프로퍼티의 일종
//    //객체 내부의 컬렉션에 대한 접근을 쉽게 진행할 수 있습니다.

//    //인덱서 사용 시의 장점
//    // 객체 내부 데이터에 배열과 비슷한 방식으로 접근이 가능합니다.
//    // 따라서 사용에 어려움이 없음.
//    // 코드도 더 간단하게 구현됩니다.

//    //인덱서 사용 안하고 컬렉션 관련 클래스를 구현했을 시의 단점
//    // 각각의 동작 하나하나를 메소드로 정의하고 호출해야 합니다.
//    // 직관적이지 않은 코드가 사용의 불편함을 줍니다.
//    class MyBookCollection_non_indexer
//    {
//        private List<string> book_list = new List<string>();

//        //책을 북 리스트에 추가하는 기능
//        public void AddToList(string book)
//        {
//            book_list.Add(book); 
//        }
//        //북 리스트에 가진 책 하나를 확인하는 기능
//        public string GetBook(int idx)
//        {
//            return book_list[idx];
//        }
//        //특정 위치의 책을 변경하는 기능
//        public void SetBook(int idx, string book)
//        {
//            book_list[idx] = book;
//        }
//    }
//    class MyBookCollection_indexer
//    {
//        private List<string> book_list = new List<string>();
//        //인덱서를 통해 책을 확인하고 책을 변경하는 작업을 하나로 표현
//        //인덱서 작성 방법
//        //[접근 제한자] 타입 this [int index]
//        //{
//        //  get { }
//        //  set { }
//        //}
//        public string this[int index]
//        {
//            get { return book_list[index]; }
//            set { book_list[index] = value; }
//        }
//        //책을 추가하는 기능
//        public void AddToList(string book)
//        {
//            book_list.Add(book);
//        }
//    }
//    internal class Class45
//    {
//        public static void Main(string[] args)
//        {
//            Sample s = new Sample();
//            s.Name = "고양이"; //고양이가 프로퍼티의 value
//            s.Name = "투썸피치 아이스티"; 
//            //초기화가 진행되는 상황에서는 프로퍼티의 set 기능이 작동합니다.
//            //s.SetName("강아지");
//            Console.WriteLine(s.Name);
//            //프로퍼티를 사용하는 경우에는 get 기능이 작동합니다.

//            //프로퍼티 Age를 만들어주세요.
//            //값 설정 단계에서 나이가 0보다 작은 수일 경우 나이는 1살부터 측정할 수 있습니다.라고
//            //유효성 검사를 진행해주세요.
//            s.Age = -57;

//            MyBookCollection_non_indexer mbc1 = new MyBookCollection_non_indexer();
//            mbc1.AddToList("원피스");
//            mbc1.AddToList("명탐정 코난");
//            mbc1.AddToList("장사의 신");
//            Console.WriteLine(mbc1.GetBook(1));
//            mbc1.SetBook(0, "책");
//            Console.WriteLine(mbc1.GetBook(0));
//            MyBookCollection_indexer mbc2 = new MyBookCollection_indexer();
//            mbc2.AddToList("원피스");
//            mbc2.AddToList("명탐정 코난");
//            mbc2.AddToList("장사의 신");

//            Console.WriteLine(mbc2[0]);
//            mbc2[1] = "C# 교과서";
//            Console.WriteLine(mbc2[1]);
//        }
//    }
//}
