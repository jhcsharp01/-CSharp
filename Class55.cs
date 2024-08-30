//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //화살표 연산자
//    //LINQ에서 제공하는 메소드들은 매개변수로 람다 식을 받습니다.
//    //람다식의 특징은 => 기호를 사용해 표현

//    //유의할 점 : 복잡하게 설계하면 성능 저하 발생

//    //유형
//    //1. (매개변수) => 식
//    //2. (매개변수) => {명령문;}
//    public delegate int Calculate(int x, int y);
//    public class Calculator
//    {
//        public int Add(int a, int b) => a + b;
//        //아래의 {} 대신 =>를 작성하고 그 뒤에 적은 값, 식이 return 됩니다.
//        public int Sub(int a, int b)
//        {
//            return a - b;
//        }
//        public int pow(int a, int e) => a * e;
//    }

//    delegate void Mydelegate();
//    internal class Class55
//    {
//        static void Main(string[] args)
//        {
//            Calculator calculator = new Calculator();
//            //화살표를 통해 바로 매개변수와 사용할 값을 표현
//            Calculate calculate = (a, b) => calculator.Add(a, b);
//            Console.WriteLine(calculate(1,5));
//            //델리게이트에서 사용할 메소드를 바로 구현
//            calculate = (a,b ) => calculator.pow(a,b);
//            Console.WriteLine(calculate(2, 5));

//            Mydelegate mydelegate = () =>
//            {
//                Console.WriteLine("델리게이트 테스트");
//                Console.WriteLine("델리게이트 테스트 2");
//                Console.WriteLine("델리게이트 테스트 3");
//            };
//        }
//    }
//}
