//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Practice
//{
//    internal class Class30
//    {
  
//        static void Main(string[] args)
//        {
//            //딕셔너리를 이용해서 아이템 상점 기능을 구현해보고자 합니다.
//            //딕셔너리는 아이템의 이름을 키로, 아이템의 가격을 값으로 가지겠습니다.
//            Dictionary<string, int> store = new Dictionary<string, int>(){{"웅담",100},{"동동주",50},{"막걸리",30}};
//            //딕셔너리 안의 아이템은 3개

//            //화면에는 딕셔너리로 넣어둔 아이템과 아이템의 가격이 순서대로 출력될 것입니다.
//            //1)딕셔너리 형태 그대로 뽑는 방법
//            //foreach(var values in store)
//            //{
//            //    Console.WriteLine(values);
//            //}
//            //2)키를 이용해서 값까지 처리하기
//            foreach(var values in store.Keys)
//            {
//                Console.WriteLine($"{values}  {store[values]:#,##0}원");
//            }
//            //사용자는 입력문을 이용해 아이템의 이름을 입력하면, 상점은 아이템에 대한 내용 소개와
//            //아이템에 대한 구매 확인을 물어보게 됩니다.
//            //구매를 진행하는 경우 구매를 성공적으로 진행할 수 있습니다.

//            //사용자는 물건(아이템의 이름)을 저장할 수 있는 리스트와 돈을 가지고 있습니다.
//            List<Dictionary<string,int>> item_list = new List<Dictionary<string,int>>();
//            int money = 1000;

//            Console.Write("구입할 물건의 이름을 입력해주세요 >> ");
//            string input = Console.ReadLine();

//            if (store.ContainsKey(input))
//            {
//                //구매 진행
//                Console.Write("몇개 구매하시겠습니까?");
//                int count = int.Parse(Console.ReadLine());
//                if(money < store[input] * count)
//                {
//                    Console.WriteLine("잔액이 부족합니다.");
//                }
//                else
//                {
//                    money -= store[input]*count;
//                    Dictionary<string, int> item = new Dictionary<string, int>();
//                    item[input] = count;
//                    item_list.Add(item);
//                    Console.WriteLine("거래가 성공했습니다!");
//                    Console.WriteLine("인벤토리 내용");
//                    foreach(var dict in item_list)
//                    {
//                        foreach (var value in dict)
//                        {
//                            Console.WriteLine(value.ToString());
//                        }
//                    }
//                    Console.WriteLine("잔액 : " + money);
//                }

//            }
//            else
//            {
//                Console.WriteLine("해당 물건은 없습니다.");
//            }
//        }
//    }
//}
