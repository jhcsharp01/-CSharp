//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    //1. abstract 클래스
//    //abstract 키워드가 붙은 클래스입니다.
//    //특징)일반적으로 abstract 키워드가 붙은 메소드를 1개 이상 가지고 있는 클래스를 의미합니다.
//    //abstract 키워드가 붙은 메소드는 선언만 하는 것이 가능합니다.

//    //사용 이유)
//    //클래스를 상속할 때, 부모의 기능을 전달 받게 되는데
//    //자식 클래스 측에서 해당 기능을 쓰지 않고 다른 기능으로 만들어 쓰는 경우가 존재
//    //이런 경우, 부모 클래스를 자식 클래스로 생성하는 다형성 구현 시에 문제가 발생합니다.(메소드의 이름이 같아야 함)
//    //virtual 키워드를 통해 자식 쪽에서 오버라이딩을 통해 다른 기능으로 구현할 수 있도록 제공은 하고 있으나
//    //반드시 진행할 필요는 없기 때문에 보장받기는 어려울 수 있습니다.
//    //따라서 abstract를 통해 해당 기능을 구현해야 사용할 수 있도록 강제성을 부여합니다.

//    //abstract로 인해 자식 클래스는 따로 메소드를 만들 상황을 줄일 수 있습니다.
//    //1. abstract class에서 abstract 메소드가 아닌 일반 메소드는 더이상 건드릴 필요가 없는 확실한 기능임을 알 수 있음.
//    //2. abstract method를 전달받아 사용하니 기본적인 틀은 제공받은 상태에서 기능만 구현하면 됩니다.
//    //3. 부모 쪽에서는 기존에 virtual을 통해 오버라이딩이 예정된 함수에 대해 기능 구현을 따로 할 필요가 없습니다.(틀만 제공)
//    abstract class ABC
//    {
//        //abstract가 붙은 메소드는 상속받은 클래스가 반드시
//        //재정의를 진행해야 사용할 수 있습니다.
//        public abstract void Method();

//        void Method2()
//        {
//            Console.WriteLine("완성된 메소드");
//        }
//    }
//    class E
//    {
//        //클래스를 상속받을 때, 재정의를 진행하기 위해
//        //virtual 키워드를 작성해 작업을 진행했습니다.
//        public virtual void Method()
//        {
//            Console.WriteLine("E 메소드 실행");
//        }
//    }
//    class Child1 : ABC
//    {
//        //오버라이딩을 진행해야 클래스 사용 가능
//        public override void Method()
//        {
//            Console.WriteLine("ABC에서 전달받은 메소드 구현 후 실행");
//        }
//    }
//    class Child2 : E
//    {
//        //오버라이딩 작업을 하지 않아도 상관은 없음.
//    }


//    internal class Class29
//    {
//        static void Main(string[] args)
//        {
//            //ABC abc = new ABC();
//            //1. abstract class는 생성할 수 없습니다.(인스턴스를 만들 수 없음)
//            E e = new E();
//            //ABC abc = new E(); 
//            Child1 c = new Child1();    
//            ABC d = new Child1();
//            //2. 자식의 생성자로 생성하는 것은 가능합니다.(abstract method에 대한 구현이 완료되서)
//            Child2 c2 = new Child2();
//            E e2 = new Child2();
//            //메소드 호출
//            e.Method();
//            c.Method();
//            d.Method();
//            c2.Method();
//            e2.Method();
//        }
//    }
//}
