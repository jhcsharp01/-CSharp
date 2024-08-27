//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //컬렉션 딕셔너리(dictionary)
//    //딕셔너리는 Key라 불리는 인덱스 번호를 대신해 사용하는 값과
//    //Value라 불리는 값을 하나의 묶음으로 다루는 자료구조를 의미합니다.

//    //Map, dictionary, dict 등 다양한 언어에서 다양한 이름으로 불리고 있습니다.

//    internal class Class28
//    {
//        //static void Method01(var var)
//        //{
//        //}
//        static void Main(string[] args)
//        {
//            //사용 방법 
//            //1. 딕셔너리 생성
//            //Dictionary<K,V> 딕셔너리명 = new Dictionary<K,V>();
//            Dictionary<string, string> dict01 = new Dictionary<string, string>();
//            //2. 데이터 형태를 자동으로 설정해주는 var를 통해 설계
//            //var는 초기화한 값에 따라 데이터 타입을 정해주는 c#의 키워드입니다.
//            //단 함수의 매개변수로는 사용할 수 없습니다.
//            var dict02 = new Dictionary<string, string>();
//            //3. 딕셔너리에 데이터 넣고 생성
//            var dict03 = new Dictionary<string, string>()
//            {
//                { "사전", "Dictionary"}
//                ,
//                { "사과", "Apple"}
//            };
//            //4. 명령어를 통해 딕셔너리에 요소 추가하기
//            dict01.Add("장난감 활", "잘 부러지게 생긴 장난감 활입니다.");
//            dict02.Add("id", "ak2222");

//            //5. 딕셔너리에 접근
//            // 딕셔너리명[키] --> 값
//            Console.WriteLine(dict01["장난감 활"]);
//            Console.WriteLine(dict01);

//            //6. 딕셔너리명.Keys : 딕셔너리 중에서 키에 대한 정보만 따로 뽑아냅니다.
//            foreach (var key in dict03.Keys)
//            {
//                Console.WriteLine(key);
//            }
//            //7. 딕셔너리명.Values : 딕셔너리 중에서 값에 대한 정보만 따로 뽑아냅니다.
//            foreach (var values in dict01.Values)
//            {
//                Console.WriteLine(values);
//            }
//            //8. 딕셔너리에 데이터 추가 / 수정하는 방법
//            //딕셔너리명[키] = 값;
//            //해당 키가 이미 존재한다면, 기존 키가 가지는 값이 변경됩니다(수정)
//            //해당 키가 없다면, 그 키를 새로 생성하는 기능으로 사용됩니다.
//            dict03["바나나"] = "Banana";
            
//            //키와 값의 특징
//            //키의 경우 딕셔너리 내부에 고유한 값으로 존재합니다.(중복 불가)
//            //값의 경우 중복이 되도 상관이 없습니다.

//            //9. 해당 키가 존재하는지를 판단하는 명령어
//            if(dict03.ContainsKey("바나나"))
//            {
//                Console.WriteLine("바나나를 가지고 있습니다.");
//            }
//            else
//            {
//                Console.WriteLine("바나나를 가지고 있지 않습니다.");
//            }


//            if (dict03.ContainsKey("참외"))
//            {
//                Console.WriteLine("참외를 가지고 있습니다.");
//            }
//            else
//            {
//                Console.WriteLine("참외는 가지고 있지 않습니다.");
//            }
//        }
//    }
//}
