//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    internal class Example07
//    {
//        static void Main(string[] args)
//        {
//            //리스트 활용(도시 5개 추가)
//            List<string> cities = new List<string>();
//            cities.Add("파리");
//            cities.Add("런던");
//            cities.Add("뉴욕");
//            cities.Add("서울");
//            cities.Add("로마");

//            //1. 리스트에 보관되어있는 값들을 문자열로 추출
//            string cities_line = string.Join(",", cities.ToArray());
//            //리스트명.ToArray()는 리스트를 배열의 형태로 변경
//            //string.join(구분자,값);
//            //여러 개의 값을 구분자를 통해 이어붙일 수 있습니다.
//            Console.WriteLine(cities_line);

//            //2. 리스트를 통해서 부분 리스트를 만들어 낼 수 있습니다.
//            //리스트 내용 중에서 일정 범위 내에 있는 요소만 추출 가능
//            List<string> range_list = cities.GetRange(1,2);
//            //리스트명.GetRange(시작위치, 개수);
//            cities_line = string.Join (",", range_list.ToArray());
//            Console.WriteLine(cities_line);
//            //3. 리스트를 통해 딕셔너리 내부의 키, 값의 목록을 얻어낼 수 있습니다.
//            //(해당 예시는 Dictionary 복습 파트에서 진행)

        
//        }
//    }
//}
