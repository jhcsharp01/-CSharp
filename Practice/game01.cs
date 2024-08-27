//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class game01
//    { 
//        static void Main(string[] args)
//        {
//            StartMenu();
//            MainMenu();
//        }
//        private static void MainMenu()
//        {
//            Console.WriteLine("게임 이름");
//            Console.WriteLine("1. 새로 하기 ");
//            Console.WriteLine("2. 이어 하기 ");
//            Console.WriteLine("3. 종료 ");
//        }
//        private static void StartMenu()
//        {
//           for(int i = 0; i < 10; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine("Loading...");
//                }
//                else
//                {
//                    Console.WriteLine("Loading......");
//                }
//                Thread.Sleep(1000); //넣어준 시간동안 스레드를 중단하는 코드
//                //스레드는 작업 중인 프로그램
//                //시간의 단위 (밀리초) : 1000밀리초 -> 1초
//                Console.Clear(); //콘솔 창을 지우는 기능
//            }
//        }
//    }
//}
