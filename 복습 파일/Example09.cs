//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    //[상속]
//    //기존 클래스로 새 클래스 만들기
//    //구조체의 경우는 상속을 진행할 수 없습니다.

////관련 키워드
//    //1. virtual : 해당 키워드가 붙은 함수는 자식 클래스에서 재정의를 진행할 수 있게 해줍니다.
//    //2. abstract : 해당 키워드가 붙은 메소드는 선언할 수 있습니다. 해당 메소드는
//    //              해당 키워드가 붙은 클래스 안에서 선언이 가능하며, 상속을 통한 재정의로 사용 가능합니다.
//    //              상속을 통한 메소드의 구현을 강제함으로써, 다형성 구현에 도움을 줍니다.
//    //3. interface : 기능의 구현이 아닌 기능의 선언을 진행하고, 이를 상속을 통해 구현하도록 합니다.
//    //               일반 상속과 다르게 여러 개를 연결해줄 수 있으며, 구현에 대한 틀을 제공합니다.
//    //4. sealed : 해당 키워드가 붙은 클래스는 상속 할 수 없습니다.
//    //5. override : 같은 이름의 메소드에 대한 재정의를 의미합니다.
//    //6. base : 기초 클래스(부모 클래스)를 의미합니다.
//    //          this는 클래스 내에서 자기 자신, this()는 자신의 생성자
//    //          base는 클래스 내에서 부모 클래스, base()는 부모의 생성자
////관련 접근 제한자
//    //1. protected : 상속의 영역까지의 접근을 허용합니다.
//    //2. public : 상속을 통해 모두 물려받을 수 있습니다.
//    //3. private : 상속으로도 접근할 수 없습니다.
//// >> 부모 클래스(상위 클래스)는 메소드 등의 구현 시 접근 제한자를 자식 클래스보다 더 큰 범위로 설계해야 합니다.

////상속 만드는 방법
////(접근 제한자) class 클래스명 : Base/Super 클래스명 { }
//    class Parent
//    {
//        public void Foo() => Console.WriteLine("부모 클래스의 멤버를 호출합니다.");
//    }
//    class Child : Parent
//    {
//        public void Bar() => Console.WriteLine("자식 클래스의 멤버를 호출합니다.");
//    }
//    class Parent2
//    {
//        public virtual void Foo() => Console.WriteLine("부모 클래스의 멤버를 호출합니다.");
//    }
//    class Child2 : Parent2
//    {
//        public int a;

//        public override void Foo()
//        {
//            base.Foo(); //Parent2의 Foo() 기능을 호출합니다.
//            Console.WriteLine("Child2의 추가 기능!");
//        }

//        //객체를 문자열의 형태로 return해주는 기능 ToString()
//        //모든 클래스는 Object 클래스를 상속하기 때문에 Object 클래스의 기능을 override할 수 있습니다.
//        //Object 클래스에 대한 상속은 따로 작성하지 않습니다.
//        //오브젝트 클래스가 가지는 메소드
//        //1. ToString() : 객체를 문자열의 형태로 return 하는 기능
//        //2. Equals(object?) : 현재의 객체와 다른 객체가 서로 같은지를 비교하는 기능
//        //3. GetHashCode() : 객체는 생성되면 원본을 식별할 수 있는 고유한 값을 따로 가지게 됩니다.
//        //                   이 값을 해시코드라고 부릅니다.
//        //                   해당 메소드를 통해 객체의 해시코드 값을 얻어올 수 있습니다.
//        public override string? ToString()
//        {
//            return base.ToString();
//        }
//    }
//    sealed class Pure
//    { }
//    //class Something : Pure { } //불가능


//    internal class Example09
//    {
//        static void Main(string[] args)
//        {
//            Child child = new Child();
//            child.Foo(); //자식 클래스 쪽에서 따로 만들지 않아도 부모 클래스의 Foo()를 그대로 사용할 수 있습니다.
//            child.Bar();

//            Child2 child2 = new Child2();
//            child2.Foo();

//            //virtual을 사용하는 이유
//            //다형성 구현을 위한 도구
//            //다형성은 하나의 객체로 여러 형태를 표현하는 기술을 말합니다.
//            //상위 클래스는 하위 클래스에 포함되기 때문에 상위 클래스로 하위 클래스를 생성하는 것이 가능합니다.
//            //단 이 경우 상위 클래스에서 정의한 메소드들만 사용할 수 있습니다.

//            Parent p = new Child();
//            Parent2 p2 = new Child2();
//            p.Foo(); //부모가 가지는 Foo()의 기능을 그대로 사용합니다.
//            p2.Foo(); //virtual을 사용하면 해당 함수를 호출한 위치 쪽의 값을 참조하게 됩니다.
//        }
//    }
//}
