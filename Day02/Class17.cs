//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    구조체(struct)
//    사용자 정의 데이터 타입
//    기본적으로 제공되는 데이터 타입이 아닌 사용자가 직접 만드는 타입
//    C#에서 만들어지는 구조체는 값 형식의 데이터

//    데이터의 형태
//    1. 값 형식(value)  : 일반적인 값(정수, 실수) 등...
//    2. 참조 형식(reference) : 클래스

//    struct 구조체명
//    {
//        자료형 변수명;       
//    }

//    C#의 struct는 구조체가 생성될 때 호출되는 생성자라는 개념을 가지고 있습니다.
//    이쪽에서 작업해야 값을 제대로 넘겨줄 수 있습니다.


//    enum Gender
//    {
//        남,녀
//    }

//    struct Student //'학생' 구조체
//    {
//        학생에게 필요한 정보를 작성합니다.
//        public int sid; //학생 순번 
//        public string name; //이름
//        public Gender gender;//성별
//        public int age; //나이
//    }

//    구조체(생성자를 수정한)
//    struct Student2 //'학생2' 구조체
//    {
//        public int sid;
//        public string name;
//        public Gender gender;
//        public int age;
//        public Student2(int sid, string name, Gender gender, int age)
//        {
//            this.sid = sid;
//            this.name = name;
//            this.gender = gender;
//            this.age = age;
//        }
//        1. 생성자(Constructor) : 클래스 또는 구조체가 가지고 있는 자신과 이름이 같은
//           함수를 의미합니다.
//        2. 생성자의 경우 일반 함수와 다르게 자료형을 적지 않습니다.
//        3. 생성자를 따로 만들지 않았을 경우 클래스 또는 구조체의 이름을 가진 함수가 생성자입니다.
//           ex) 위의 Student의 생성자는 Student();
//        4. 생성자를 통해 생성하는 방법은 다음과 같습니다.
//           구조체명 변수명 = new 생성자명();
//        5. 생성자를 수정했을 경우, 생성자의 형태에 맞게 생성을 진행해야 합니다.
//           위의 Student2처럼 매개변수가 추가됬다면 생성 시 값을 넣어서 생성을 진행해야 합니다.
//           Student2 st2 = new Student2(1,"a",Gender.남,20);
//    }



//    internal class Class17
//    {
//        액션을 진행한다.
//        static void Action()
//        {
//            Console.WriteLine("액션을 진행합니다.");
//        }

//        구조체를 활용해서 함수 만들기
//        ref 추가(ref는 참조자라고 불리며, 실제 값에 접근할 수 있습니다.)
//        static void StudentSetting(ref Student s, int id, string name, Gender gender, int age)
//        {
//            s.sid = id;
//            s.name = name;
//            s.gender = gender;
//            s.age = age;
//        }
//        구조체 s1과 s2만 넣어주면 동일한 문법을 보장받을 수 있습니다.
//        static void StudentInfo(Student s)
//        {
//            Console.WriteLine("순번\t이름\t성별\t나이");
//            Console.WriteLine($"{s.sid} | {s.name} | {s.gender} | {s.age}");
//        }
//        static void Main(string[] args)
//        {
//            Student s1; //구조체 선언
//            s1 = new Student(); //구조체 생성
//            생성할 경우 구조체가 가지는 값은 기본 값을 가지게 됩니다.(기본 값이란 각 데이터 별로 가장 처음 값 0)

//                                    s1.sid = 1;
//                                   s1.name = "투썸레몬";
//                                    s1.gender = Gender.남;
//                                    s1.age = 24;
//            StudentSetting(ref s1, 1, "투썸레몬", Gender.남, 24);
//            Console.WriteLine(s1.sid);
//            선언만 된 구조체를 넣어서 작업하는 것은 불가능합니다.
//            이 경우 구조체 생성을 통해 구조체를 초기화하여 작업합니다.
//            StudentInfo(s1);
//            Student s2; //구조체 선언
//            s2.sid = 2;
//            s2.name = "카모마일";
//            s2.gender = Gender.녀;
//            s2.age = 22;
//            구조체로 작업을 할 경우 구조체의 변수로 구분하기 때문에 변수의 이름을
//            재활용하기 좋습니다.
//            int sid, string name, Gender gender, int age
//            Student2 student2 = new Student2(1,"김가을",Gender.녀,25);
//            Console.WriteLine($"{student2.sid} | {student2.name} | {student2.gender} | {student2.age}");
//        }
//    }
//}
