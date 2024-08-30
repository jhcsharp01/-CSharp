using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Land;

namespace GAME1
{
    public class Unit
    {
        public static void Method() => Console.WriteLine("메소드 실행");
    }
}
namespace Animal
{
    namespace Land
    {
        public class Rabbit
        { 
            public static void Method() => Console.WriteLine("나는 토끼요.");     
        }
    }
}
namespace ConsoleApp1
{
    //네임스페이스 사용)
    //프로그램의 규모가 커질 때 클래스의 이름이 충돌할 것을 방지하기 위해
    //모아서 관리하는 개념
    //큰 프로젝트 개발을 진행하는데 A도 Unit, B도 Unit만들고 하다보면
    //충돌이 발생할 수 있어서 이를 방지
    public partial class Unit
    {
        public static void Method() => Console.WriteLine("메소드1 실행");
    }

    //클래스 기능) partial class
    //클래스를 부분적으로 구현하는데 사용하는 키워드입니다.

    internal class Class58
    {
        //static void Main(string[] args)
        //{
        //    Unit.Method();
        //    Unit.Method();
        //    Rabbit.Method();
        //    //using으로 namespace를 연결해놓으면
        //    //해당 영역의 데이터를 사용할 수 있습니다.
        //}
    }
}
