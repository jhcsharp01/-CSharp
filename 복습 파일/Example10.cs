//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    //1. 인터페이스를 사용해 편하게 기능을 구현합니다.
//    //Person에 IComparable<T>를 연결합니다.
//    class Person : IComparable<Person>
//    {
//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }
//        public string Name { get; set; }
//        public int Age { get; set; }

//        //객체에 대한 비교를 진행할 수 있게 코드를 설계합니다.
//        int IComparable<Person>.CompareTo(Person? other)
//        {
//            return Age - other.Age;
//        }
//        public override string? ToString()
//        {
//            return $"[{Name}, {Age}]";
//        }
//    }
//    class Music : IComparable<Music>
//    {
//        public Music(string name, int day, int view)
//        {
//            Name = name;
//            Day = day;
//            View = view;
//        }
//        public string Name { get; set; }
//        public int Day { get; set; }
//        public int View { get; set; }

//        public int CompareTo(Music? other)
//        {
//            return -(View - other.View);
//        }

//        public override string? ToString()
//        {
//            return $"[{Name}, {Day} ,{View}]";
//        }
//    }


//    internal class Example10
//    {
//        static void Main(string[] args)
//        {
//            Person p1 = new Person("Mihael kail",40);
//            Person p2 = new Person("Jack Huestain",22);
//            Person p3 = new Person("Mary Jane",37);

//            List<Person> list = new List<Person>();
//            list.Add(p1);
//            list.Add(p2);
//            list.Add(p3);
//            foreach (Person p in list)
//            {
//                Console.WriteLine(p);
//                //ToString() 문법 수정 이후 객체 그 자체를 출력하면
//                //수정한 형태로 출력됩니다.
//            }
//            list.Sort(); //정렬 진행
//            //현재 위의 예제는 나이 순으로 작성을 진행해놨습니다.
//            //아래의 기능을 확인하기 위해 나이를 섞어주겠습니다.
//            foreach (Person p in list)
//            {
//                Console.WriteLine(p);
//                //ToString() 문법 수정 이후 객체 그 자체를 출력하면
//                //수정한 형태로 출력됩니다.
//            }

//            //클래스 음악은 IComparable<음악>을 상속받고 있습니다.
//            //음악에는 음악명 출시일 조회수를 가지고 있습니다.
//            //음악을 만들 때는 이름,출시일,조회수를 순서대로 넣어서 생성합니다.
//            //음악에 대한 내용 출력 시 [이름, 조회수 , 출시일] 순으로 출력됩니다.
//            //음악 리스트를 통해 정렬을 진행할 경우 조회수를 기준으로 내림차순을 진행합니다.
//            //음악 리스트에 음반 5개 넣어주세요.

//            Music music1 = new Music("song1", 20240829, 12312547);
//            Music music2 = new Music("song2", 20240829, 456798709);
//            Music music3 = new Music("song3", 20240829, 99900);

//            List<Music> music_list = new List<Music>();

//            music_list.Add(music1);
//            music_list.Add(music2);
//            music_list.Add(music3);

//            music_list.Sort();
//            foreach(Music m in music_list)
//            {
//                Console.WriteLine(m);
//            }

//        }
//    }
//}
