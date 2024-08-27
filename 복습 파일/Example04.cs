//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    //메소드(함수) 사용법
//    //1) Static vs Instance

//    //static는 변수나 함수에 키워드로 붙습니다.
//    //static이 변수에 붙는 경우 클래스가 메모리에 올라갈 때 자동으로 생성됩니다.
//    //객체를 반복적으로 생성해도 메모리가 유지된다.
//    //인스턴스 생성 없이 바로 사용이 가능합니다.

//    //static 사용 목적
//    //클래스의 일반 멤버 변수는 클래스의 객체가 생성될 때 각 객체마다 따로 주어집니다.
//    //static을 사용한 경우라면 해당 클래스가 사용될 때 한번만 초기화가 진행되고
//    //동일한 메모리를 사용하게 됩니다.(공통적으로 사용되는 데이터의 관리)

//    //2. void vs ...
//    //void는 비어있는 타입을 의미합니다.
//    //void로 함수를 설계할 경우 따로 return을 통해 값을 전달할 필요가 없습니다.

//    //그 이외의 함수는 데이터의 형태에 따라 return 값을 넘겨줘야 합니다.

//    //3. 매개변수(parameter)
//    //함수를 호출할 때 넣어줄 값(Argment)에 대한 데이터 표현
//    //함수의 구현부에서 전달받을 값을 저장할 변수
//    //매개변수는 값을 전달받아 그 값을 복사해서 만드는 별개의 변수
    

//    class Cal
//    {
//        public int value1;
//        public static int value2;

//        public static void Method01()
//        {
//            //value1 = 5; static 메소드 안에서는 static 변수의 값 수정 가능
//            value2 = 7;
//            Console.WriteLine("메소드01을 호출했습니다.");
//            Console.WriteLine(value2);
//        }

//        public static void ValuePlus()
//        {
//            value2++;
//        }
//        public static void ValueInfo()
//        {
//            Console.WriteLine(value2);
//        }

//        public void Method02()
//        {
//            Console.WriteLine("메소드02를 호출했습니다.");
//            Console.WriteLine(value2);       
//        }
//    }
//    internal class Example04
//    {
//        //숫자의 제곱 표현(number의 exponent 제곱)
//        static int NumberPow(int number,  int exponent)
//        {
//            int result = 1; //결과를 저장할 변수 result 
//            for(int i = 0; i < exponent; i++)
//            {
//                result *= number;
//            }
//            return result; //함수의 타입에 따라 반드시 맞는 값을 내보내줍니다.
//            //return은 함수를 종료하고 작성한 값을 함수가 호출된 위치로 전달하는 역할
//        }
//        static void NumberPow2(int number, int exponent)
//        {
//            //void 타입의 경우 내보낼 값이 없기에 return 값을 내보낼 필요가 없습니다.
//            //void로 만드는 경우는 해당 함수의 실행이 작업의 끝이라고 보면 됩니다.
//            int result = 1; //결과를 저장할 변수 result 
//            for (int i = 0; i < exponent; i++)
//            {
//                result *= number;
//            }
//            Console.WriteLine($"{number}의 {exponent} 제곱 = {result}");
//            return; //함수의 종료만 진행합니다.
//        }

//        /// <summary>
//        /// 숫자 2개를 넣고, 그 숫자의 값을 서로 변경하는 함수
//        /// </summary>
//        /// <param name="a">첫번째 값</param>
//        /// <param name="b">두번째 값</param>
//        static void Swap(int a, int b)
//        {
//            int temp = a; //하나의 값을 저장합니다.
//            a = b;  //기존의 값에 다른 값을 저장합니다.
//            b = temp;//다른 값에 저장해둔 값을 저장합니다.
//            Console.WriteLine($"a = {a} b = {b}");
//        }

//        //static int Swap2(int a, int b)
//        //{
//        //    int temp = a;
//        //    a = b;  
//        //    b = temp;
//        //    return a,b; //여러 개의 값을 return 할 수 없습니다.
//        //}

//        //call by value(값에 의한 호출)로는 원본의 수정이 불가능한 상태
//        //call by reference(참조에 의한 호출)로 작업 처리
//        static void Swap2(ref int a, ref int b)
//        {
//            int temp = a; //하나의 값을 저장합니다.
//            a = b;  //기존의 값에 다른 값을 저장합니다.
//            b = temp;//다른 값에 저장해둔 값을 저장합니다.
//            Console.WriteLine($"a = {a} b = {b}");
//        }      
//        static void Main(string[] args)
//        {
//            //1. static 메소드 : 클래스 메소드라고도 부르며 클래스명.메소드명()으로 호출이 가능합니다.
//            Cal.Method01();
//            Cal.value2 = 5; //static 변수
//            Cal.ValueInfo();

//            //2. 인스턴스 메소드 : 클래스로 생성한 인스턴스를 통해 사용하는 메소드입니다.
//            Cal cal = new Cal();
//            cal.value1 = 7;
//            cal.Method02();
//            Cal.ValuePlus();
//            cal.Method02();

//            //1. void가 아닌 함수를 사용하는 경우 호출 결과를 전달받아 그 이후의 작업을 설계합니다.
//            int result = NumberPow(2, 3); //함수의 호출 결과를 저장합니다.
//            Console.WriteLine(result); //그 결과를 출력합니다.

//            //2. void 함수라면 그 함수를 호출하는 것으로 작업 종료
//            NumberPow2(2, 3);

//            int a = 7;
//            int b = 8;
//            //Swap(a, b);
//            Swap2(ref a, ref b); //ref 키워드를 통해 a와 b를 넘깁니다.(a ,b를 값이 아닌 참조 전달이 가능 해짐.)
//            Console.WriteLine($"[Main] a = {a} b = {b}");
//        }
//    }
//}
