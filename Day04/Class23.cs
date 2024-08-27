//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    다음 조건의 클래스를 구현하시오.
//    1. 스마트폰에 대한 클래스를 만들어줍니다.
//    2. 스마트폰의 필드 값은 다음과 같습니다.
//       이름, 화면 크기 , 통신 규격
//       내장메모리 , 운영체제, 제조사
//    3. 스마트폰의 메소드는 다음과 같습니다.
//       Info() : 스마트폰에 대한 내용 출력
//    출력 예시)
//    삼성전자 갤럭시 S24 5G+LTE 256GB
//    4. 클래스의 생성은 생성자를 만들어서 진행합니다.

//    public class SmartPhone
//    {
//        private string name;
//        private float inch;
//        private string protocol;
//        private int RAM;
//        private string OS;
//        private string brand;
//        Visual Studio에서 간단하게 생성자를 만드려면 리팩토링 기능을 이용해 설계합니다.
//        생성자(Constructor)
//        1. 별도의 타입이 없습니다.
//        2. 클래스와 이름이 동일한 메소드입니다.
//        3. 생성자를 수정할 경우 생성 시 그 형태에 맞게 작업을 진행합니다.
//        4. 생성자를 따로 안만들었을 경우, 생성자는 클래스명();이 됩니다.
//        5. 기본 생성자를 쓰고 싶을 경우에는 추가해서 작업해줍니다.

//        기본 생성자 : 따로 설계 안했을 때의 기본 생성자 형태를 의미합니다.
//                     클래스를 선언만 하는 것이 가능합니다.
//        this는 클래스 자신이 가지는 것임을 표현하는 키워드입니다.
//        public SmartPhone()
//        {

//        }

//        public SmartPhone(string name, float inch, string protocol, int rAM, string oS, string brand)
//        {
//            this.name = name;
//            this.inch = inch;
//            this.protocol = protocol;
//            RAM = rAM;
//            OS = oS;
//            this.brand = brand;
//        }

//        public void Info()
//        {
//            Console.WriteLine($"{brand} {name} {protocol} {RAM}GB");
//        }

//    }

//    internal class Class23
//    {
//        static void Main(string[] args)
//        {
//            SmartPhone galaxyS24 = new SmartPhone("갤럭시 S24",6.1f, "5G+LTE",256,
//                "안드로이드14","삼성전자");
//            galaxyS24.Info();
//            SmartPhone empty = new SmartPhone();
//            empty.Info();
//        }

//    }
//}
