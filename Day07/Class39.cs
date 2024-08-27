//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Day07
//{
//    //사용자 예외 클래스 만드는 방법
//    //1. class 클래스명 : Exception

//    public class LoginException : Exception
//    {
//        //예외 클래스 만들 시 저 4개의 생성자를 반드시 작성해주도록 합니다.

//        //기본 생성자
//        //생성자() : base()는 해당 생성자가 기존의 값의 형태로 생성됨을 알려줍니다.
//        //C#의 이니셜라이저(Initializer)
//        public LoginException() : base()
//        {

//        }
//        //에러에 대한 메세지를 넣어줄 수 있는 생성자
//        public LoginException(string? message) : base(message)
//        {
//        }

//        //에러 메세지와 내부의 예외를 포함하는 생성자
//        public LoginException(string? message, Exception? innerException) : base(message, innerException)
//        {
//        }
//        //입력 스트림을 활용한 생성자
//        protected LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//        }

//        //속성(프로퍼티)
//        public string ID { get; set; }
//        public string PW { get; set; }

//    }


//    class PositivenNumber : Exception
//    {
//        public PositivenNumber() : base()
//        {
//        }

//        public PositivenNumber(string? message) : base(message)
//        {
//        }

//        public PositivenNumber(string? message, Exception? innerException) : base(message, innerException)
//        {
//        }

//        protected PositivenNumber(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//        }

//        public int Number { get; set; }
//    }


//    internal class Class39
//    {
//        //연습 문제) 오로지 양수만 입력받는 프로그램 코드를 구현하려고 합니다.
//        //          예외 발생 시 안내문을 잘 출력해주세요.


//        static void PrintNumber(int number)
//        {
//            if (number < 0)
//            {
//                throw new PositivenNumber("양수만 입력해주세요!");
//            }

//        }

//        static void Login(string id, string pw)
//        {
//            //아이디가 비거나 , 비밀번호가 빈다면
//            if (string.IsNullOrEmpty(id) == true || string.IsNullOrEmpty(pw))
//            {
//                //로그인 오류 발생
//                throw new LoginException("아이디 또는 비밀번호를 제대로 입력해주세요.")
//                {
//                    ID = id
//                    ,
//                    PW = pw
//                };

//            }
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                PrintNumber(int.Parse(Console.ReadLine()));
//                string id = string.Empty;
//                string pw = "123asd";
//                Login(id, pw);


//            }
//            catch (LoginException login_e)
//            {
//                Console.WriteLine(login_e.Message);
//                Console.WriteLine("로그인 시 아이디 : " + login_e.ID);
//                Console.WriteLine("로그인 시 비밀번호 : " + login_e.PW);
//            }
//            catch (PositivenNumber p_e)
//            {
//                Console.WriteLine(p_e.Message);

//            }
//        }
//    }
//}
