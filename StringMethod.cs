//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //문자열에 관련된 도구 , 작업들을 모아놓은 코드

//    //string = 문자열을 의미하는 키워드
//    //       = 문자열이란 char(문자)의 배열을 의미하며 " "로 표현합니다.
//    //       = char는 단일 문자로 ' '로 표현합니다.
//    //int, float와 달리 기본 데이터 타입이 아니며, 참조 형식입니다.
//    //불변성을 가지고 있습니다.(immutable)
//    //string은 문자를 작업하기 위한 다양한 메소드를 제공하고 있습니다.(★★★)
//    internal class StringMethod
//    {
//        static void Main(string[] args)
//        {
//            //1. Split()
//            //문자열을 나누는 기능
//            string str = "I am alone";
//            string[] words = str.Split('l');
//            //자르는 과정에서 기준이 되는 값은 삭제됩니다.
//            //() 안에 다른 값을 넣지 않는다면 공백을 기준으로 제거합니다.
//            foreach (string word in words)
//            {
//                Console.WriteLine(word);
//            }
//            //2.Substring() : 문자열에서 찾고자 하는 문자를 빼낼 수 있습니다.
//            str = "바나나맛우유";
//            //     0 1 2 3 4 5

//            //1. Substring(숫자) : 해당 번째에 있는 문자부터 남는 문자열을 다 빼옵니다.
//            string strA = str.Substring(1);
//            Console.WriteLine(strA);
//            //2. Substring(숫자,개수) : 해당 번째에 있는 문자부터 개수만큼의 문자열을 빼옵니다.
//            string strB = str.Substring(0, 3);
//            Console.WriteLine(strB);
//            //3. CompareTo() / Equals()
//            // 문자열에 대한 비교를 진행합니다.
//            // CompareTo는 결과를 숫자로 return하며 0이면 true, 1이나 -1로 나오면 false를 의미합니다.
//            // Equals는 결과를 bool로 return하며 True or False로 처리합니다.
//            string str2 = "하와이안 피자";
//            Console.WriteLine(str2.CompareTo("콤비네이션 피자"));
//            Console.WriteLine(str2.Equals("하와이안 피자"));
//            Console.WriteLine(str2 == "하와이안 피자");

//            //4. 문자열 바꿔치기(Replace(기존의 문자열, 새로운 문자열))
//            //문자열에서 특정 문자를 검색해서 그 문자를 새로운 문자로 변경해주는 기능
//            string values = "토마토 기러기 오디오 스위스"; //palindrome(회문)
//            values = values.Replace("기러기", "refer");
//            Console.WriteLine(values);

//            //5. 문자열이 포함되어있는가? Contains
//            string str3 = "처음처럼";
//            if(str3.Contains("처음"))
//            {
//                Console.WriteLine(str3);
//            }
//            //6. 해당 문자열이 지정한 문자열로 시작, 끝나는지 확인
//            //  StartsWith , EndsWith
//            string str4 = "Welcome to the Land of Gold";
//            Console.WriteLine(str4.StartsWith("Welcome"));
//            Console.WriteLine(str4.StartsWith("Land"));
//            Console.WriteLine(str4.EndsWith("Land"));
//            Console.WriteLine(str4.EndsWith("Gold"));
//            //7. 대소문자 변경
//            Console.WriteLine(str4.ToUpper());
//            Console.WriteLine(str4.ToLower());
//            //8. 문장 -> 문자의 배열로 분배
//            string str5 = "apple";
//            char[] chars = str.ToCharArray();

//            //9. 문자열이 숫자인지 판단하는 방법
//            bool anwer = int.TryParse("1111", out int result); 
//            //str5를 대상으로 int.Parse를 진행합니다.
//            //out을 이용해 변환된 값을 넘깁니다.
//            //성공 여부를 bool의 형태로 return합니다.
//            Console.WriteLine(anwer);
//            Console.WriteLine(result);
//            //이 방식은 당연히 try-catch문으로도 처리가 가능합니다.
//            //하지만 try-catch는 시간 문제가 발생할 수 있습니다.
//        }
//    }
//}
