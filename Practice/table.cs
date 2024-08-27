//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //화면에 나오는 표를 화면에 출력해볼 겁니다.
//    //단 빈 칸이 하나라도 잇는 데이터는 제외합니다.
//    //표를 통해 구조체 customer를 만들어줍니다.
//    //만약 표에 중복된 고객이 존재할 경우 1개의 내용만 사용합니다.
    
//    struct customer
//    {
//        public string name;
//        public int year;
//        public string address;
//        public string phone_number;
//        public string item;
//        public int price;
//        public int count;
//        public customer(string name, int year, string address, string phone_number, string item, int price, int count)
//        {
//            this.name = name;
//            this.year = year;
//            this.address = address;
//            this.phone_number = phone_number;
//            this.item = item;
//            this.price = price;
//            this.count = count;
//        }
//    }
    
//    internal class table
//    {
//        static void PrintTable(customer[] c)
//        {
//            Console.WriteLine("==============================================");
//            Console.WriteLine("고객명 출생년도 주소 연락처 구매목록 단가 수량");
//            Console.WriteLine("==============================================");
//            for (int i = 0; i < c.Length; i++)
//            {
//                Console.WriteLine($"{c[i].name} {c[i].year} {c[i].address} {c[i].phone_number} {c[i].item} {c[i].price} {c[i].count}");
//            }
//            Console.WriteLine("==============================================");
//        }
//        static void Main(string[] args)
//        {
//            customer[] customers =
//            {
//                new customer("김용수",1979,"서울","010-222-2222","USB",11000,1)
//                ,
//                new customer("유성연",1988,"전남","019-777-4444","책",13000,1)
//                ,
//                new customer("차주원",1965,"경기","010-444-4444","샤프",3000,1)
//                ,
//                new customer("임현식",1960,"경북","011-555-5555","음료수",1500,30)
//                ,
//                new customer("성시경",1997,"경북","012-666-6666","책",17000,1)
//                ,
//                new customer("양미현",1991,"서울","010-777-7777","노트",2000,5)
//                ,  
//                new customer("임무혁",1993,"경북","011-888-8888","샤프",3000,1)
//            };
//            PrintTable(customers);
//        }
//    }
//}
