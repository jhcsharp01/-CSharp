//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //가변 인자(params)
//    //매개변수는 일반적으로 개수가 지정되어잇고 그 개수만큼 넣어줘야 합니다.
//    //ex) void Start(int a, int b, int c)라고 설계되어있으면 호출 시
//    //Start(1,2,3);과 같이 넣어줘야 합니다.
//    //저런 개수 제한에서 벗어나 자유롭게 매개변수를 넘기기 위한 용도로 params를 활용합니다.

//    //사용 규칙
//    //1. 선언부에서 params 키워드는 타입의 맨 앞에 존재해야 합니다.
//    //2. 가변인자 매개변수를 선언할 때는 []를 이용해 1차원 배열로 선언해야 합니다.
//    //3. 매개변수는 쉼표로 구분을 진행합니다.
//    //4. params로 설계한 매개변수를 따로 보내지 않아도 됩니다.

//    internal class Class36
//    {
//        //1. params 사용
//        public static void Add(params int[] arrays)
//        {
//            //배열의 작업 방식으로 코드를 설계

//            int sum = 0;
//            foreach (int i in arrays)
//            {
//                sum += i;
//            }
//            Console.WriteLine("파라미터의 길이 : " + arrays.Length.ToString());
//            Console.WriteLine("숫자의 합 : " + sum);
//        }
//        //2. params 사용 / 타입 일반화
//        public static void ParaPrint(params object[] data_params)
//        {
//            //object는 모든 타입의 조상
//            foreach (object obj in data_params)
//            {
//                Console.WriteLine(obj.ToString());
//            }

//            //★★★ 오브젝트 안에서 같은 타입만 취급하기
//            foreach (object obj in data_params)
//            {
//                var t = obj.GetType(); //오브젝트가 가지고 있는 타입을 얻어올 수 있습니다.
//                //Type 클래스는 타입을 표현할 때 사용하는 클래스입니다.
                
//                if(t.Equals(typeof(int))) //오브젝트에서 얻어온 타입이 int 타입일 경우
//                {
//                    Console.WriteLine(obj.ToString());
//                }
//            }
//        }


//        static void Main(string[] args)
//        {
//            Add();
//            Add(1);
//            Add(1,2);
//            Add(1,2,3);
//            Add(1,2,3,4);
//            Add(1, 2, 3, 4, 5);
//            ParaPrint(1, 2, "3", "야호", 3.14f);
//        }
//    }
//}
