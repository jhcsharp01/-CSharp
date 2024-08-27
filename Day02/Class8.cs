//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //로그인 구현
//    //1. 기존에 아이디와 비밀번호가 별도로 저장이 되어있음.
//    //2. 입력을 통해서 아이디와 비밀번호로 로그인을 시도합니다.
//    //3. 아이디가 틀렸을 경우 "해당 아이디는 없습니다."를 출력합니다.
//    //4. 비밀번호가 틀렸을 경우에는 "비밀번호가 틀렸습니다."를 출력합니다.
//    //5. 아이디와 비밀번호가 모두 일치하는 경우 "로그인 성공"를 출력합니다.

//    //멘트는 자유롭게
//    internal class Class8
//    {
//       static void Main(string[] args)
//       {
//            // 1
//            string id = "tester01";
//            string pw = "eta145";
//            // 2
//            Console.Write("아이디를 입력해주세요 >> ");
//            string input_id = Console.ReadLine();
//            Console.Write("비밀번호를 입력해주세요 >> ");
//            string input_pw = Console.ReadLine();

//            if (input_id != id) //입력한 아이디가 저장한 아이디와 다른 경우
//            {
//                Console.WriteLine("해당 아이디가 없습니다.");
//            }
//            else if (input_pw != pw)
//            {
//                Console.WriteLine("비밀번호가 틀렸습니다.");
//            }
//            else
//            {
//                Console.WriteLine("로그인에 성공했습니다.");
//            }

//       }
//    }
//}
