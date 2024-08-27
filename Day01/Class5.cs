//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class5
//    {
//        //1.  bmi 공식 :  kg / m * m
//        //2.  입력은 cm와 kg을 입력받습니다.

//        static void Main(string[] args)
//        {
//            int cm, kg;
//            float m;
//            float BMI;
//            string bmd;

//            //[입력]
//            Console.Write("신장 ");
//            string input = Console.ReadLine();
//            cm = int.Parse(input);
//            m = cm * 0.01f;

//            Console.Write("체중 ");
//            input = Console.ReadLine();

//            //[수치 변경 / 설정]

//            kg = int.Parse(input);
//            //조건에 따라 비만도와 BMI 지수 결정
//            BMI = kg / (m * m);
            
//            //BMI 지수의 조건에 따라 비만도 결과 설정
//            if (BMI <= 18.5)
//                bmd = "저체중";
//            else if (BMI > 18.5 && BMI <= 23)
//                bmd = "정상";
//            else if (BMI > 23 && BMI <= 25)
//                bmd = "정상";
//            else
//                bmd = "과체중";
//            //[출력]
//            Console.WriteLine($"신장 {cm}cm / 체중 {kg} kg");
//            Console.WriteLine($"비만도 결과 {bmd}입니다.");
//            Console.WriteLine($"BMI 지수  {BMI : #.##}");
//        }
//    }
//}
