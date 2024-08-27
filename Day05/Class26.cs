//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    상속 관계에서는 새로 만들 클래스와 기존에 존재하던 클래스로 나뉘게 되는데 각각을 다음과 같이 부르겠습니다.
//    새로 만들 클래스 : 자식 클래스, 파생 클래스, 응용 클래스
//    기존에 존재하던 클래스 : 부모 클래스, 기초 클래스, 기본 클래스

//    상속과 관련된 기능들
//    1. sealed class : sealed 키워드가 붙은 클래스는 상속을 위한 기본 클래스로 사용할 수 없습니다.
//    sealed class Parent
//     class Parent
//    {
//        public int number;
//        public Parent()
//        {
//            Console.WriteLine("부모 클래스가 생성되었습니다.");
//        }
//    }
//    class Child : Parent //sealed를 사용했다면 오류가 발생했을 것
//    {

//    }
//    2. override , virtual
//    virtual : 오버라이드를 진행할 메소드에 붙여주는 키워드입니다.
//    override : 부모의 기능을 재정의하는 키워드입니다.
//    class Parent2
//    {
//        public virtual void A() { Console.WriteLine("(virtual) 부모 클래스의 A() 메소드를 호출했습니다"); }
//        public void B() { Console.WriteLine("부모 클래스의 B() 메소드를 호출햇습니다."); }
//    }
//    class Child2 : Parent2
//    {
//        public override void A()
//        {
//            base.A(); //base는 기존 클래스를 의미합니다.
//            Console.WriteLine("(override) 자식 클래스의 A()를 정상적으로 호출했습니다.");
//        }
//        public void B() { Console.WriteLine("자식 클래스의 B() 메소드를 호출햇습니다."); }
//    }
//    3. new
//    생성할 때 쓰는 new가 아닌, 필드나 메소드에 붙여주는 new는 부모 클래스의 멤버(member)를 숨기는 기능
//    멤버 : 클래스의 필드, 메소드를 의미합니다.
//    class Parent3
//    {
//        public int x = 500;
//        public void A()
//        {
//            Console.WriteLine("부모 클래스의 A() 메소드를 호출했습니다");
//        }
//    }
//    class Child3 : Parent3
//    {
//        public new int x = 400;
//        public new void A()
//        {
//            Console.WriteLine("자식 클래스의 A() 메소드를 호출했습니다");
//        }
//    }
//    internal class Class26
//    {

//        static void Action(Parent2 parent)
//        {
//            parent.A();
//        }

//        static void Main(string[] args)
//        {
//            Parent2 p = new Parent2();
//            Child2 c = new Child2();
//            Parent2 p1 = new Child2(); //부모 클래스를 자식 형태의 생성자를 통해 생성(다형성(metamorphism))
//            자식 클래스를 많이 만들어두면, 부모 클래스의 데이터를 자식 클래스의 형태로 생성하는 것으로,
//                                       하나의 객체로 여러 가지의 객체를 표현하는게 가능합니다.

//            Parent3 p2 = new Parent3();
//            p2.A();
//            Child3 c3 = new Child3();
//            c3.A();
//            Action(c);
//        }
//    }
//}
