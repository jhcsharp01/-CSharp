//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    //예외란?(Exception)
//    //프로그램 개발을 하다보면, 발생할 수 있는 오류 상황 중에서
//    //사용자가 예측이 가능하고 코드를 통해 작업을 처리할 수 있는 오류
//    //ex)유니티의 NullReferenceException : 레퍼런스가 비어있는 상황 
//    //ex)C#의 IndexOutOfRangeException : 인덱스 범위를 넘었을 때의 상황...

//    //오류(Error)
//    //사용자가 예측할 수 없는 오류
//    //사용자가 코드를 통해 작업을 처리할 수 없는 상황(코드 재설계로 해결)

//    //예외를 처리하는 방법?
//    //1.예외 상황이 발생하지 않도록 코드를 설계합니다.
//    //2.예외가 발생했을 때에 대한 설계를 진행합니다.

//    //예외 처리 1(Exception handling 1) - 기본 사용법
//    internal class Class33
//    {
//        static void Main(string[] args)
//        {
//            //try문을 통해 예외가 발생할 수 있는 문장을 감싸줍니다.
//            try
//            {
//                int[] numbers = { 1, 2, 3 };
//                Console.Write(numbers[4]);
//            }
//            //예외가 발생 시 catch에서 설계한 작업이 대신 처리되는 방식
//            //일은 발생했고, 그에 대한 수습같은 느낌의 코드
//            //프로그램에서 오류가 발생하면 프로그램이 꺼지기 때문에 그에 대한 방지 개념
//            catch (Exception ex)
//            {
//                Console.WriteLine("누가 배열쓰는데 인덱스를 넘냐");
//            }
//        }
//    }
//}
