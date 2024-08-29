//#define ONPLAY
////ONPLAY를 정의합니다.
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;//Conditional
//using System.Linq;
//using System.Runtime.InteropServices;//DLLImport를 정의하고 있는 네임스페이스
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Day10
//{
//    //Attribute(특성)
//    //클래스에 메타 데이터를 추가할 수 있도록 제공되는 것
//    //※ 메타 데이터(Meta Data) : 일반적으로 데이터에 관한 구조화된 데이터

//    //유니티의 [ContextAssetMenu]같은 게 대표적인 Attribute

//    //유니티에서 사용되는 Attribute
//    //[Range(시작,끝)] 정수나 실수에 붙이면 범위 표현(인스펙터에서 슬라이드 바처럼 조절 가능)
//    //[TextArea(가로,세로)] 문자열에 붙여주면 문장을 가로 x 세로로 맞춰서 입력 가능
//    //[Serializable] 클래스나 구조체에 붙여줄 경우 인스펙터에서 필드 값을 볼 수 있습니다

//    //종류) 1. 내장된 Attribute
//    //     2.  사용자 정의 Attribute
//    class MessageAttribute : Attribute
//    {
//        private string _message;

//        //기능으로 만들어본 프로퍼티
//        public string Message
//        {
//            get => _message;
//            set => _message = value;
//        }
//    }

//    [Message]
//    internal class Class46
//    {
//        //ONPLAY가 코드 내에 정의되어 있다면(define) 해당 기능을 호출할 수 있습니다.
//        [Conditional("ONPLAY")]
//        public static void OnPlayMethod()
//        {
//            Console.WriteLine("OnPlayMethod");
//        }
//        [Conditional("ONEXIT")]
//        public static void OnExitMethod()
//        {
//            Console.WriteLine("OnExitMethod");
//        }

//        //[Obsolete("Attack()은 버전 업하여 더이상 사용하지 않습니다. Attack02()로 수정해주세요.",true)] 경고가 아닌 에러로 띄우고 싶을 경우
//        [Obsolete("Attack()은 버전 업하여 더이상 사용하지 않습니다. Attack02()로 수정해주세요.")]
//        public static void Attack()
//        {
//            Console.WriteLine("공격을 진행합니다.");
//        }

//        public static void Attack02()
//        {
//            Console.WriteLine("공격을 멋진 액션과 함께 진행합니다.");
//        }

//        //[DllImport("Calculate.dll")]
//        //주의사항 : 해당 기능은 정해진 위치에 dll 파일을 가지고 있을 때 사용이 가능합니다.
//        //일반적인 경로 : C:\Windows\System32
//        //관련 파일들까지 다 넘겨주면 외부의 코드를 연결해서 사용이 가능합니다.
//        public static extern int Add(int param1, int param2);

//        static void Main(string[] args)
//        {
//            OnPlayMethod();
//            OnExitMethod(); //현재 코드에 ONEXIT가 정의되지 않았기 때문에 컴파일 되지 않고 따라서 실행도 안됨.(호출 생략)
//            Attack();
//            //Console.WriteLine(Add(2, 5));
//        }
//    }
//}
