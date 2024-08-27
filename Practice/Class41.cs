//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Practice
//{
//    //다음과 같은 조건으로 클래스 및 인터페이스를 설계해 메인 코드에서 실행하시오.
//    //1. 클래스의 이름 : Customer
//    //2. 인터페이스의 이름 : Buy, Sell
//    //3. Buy에는 method buy()가 존재하며, 고객이 고른 물건을 구입하는 기능을 구현해야 합니다.
//    //4. Sell에는 method sell()이 존재하며, 본인이 가진 물건을 판매하는 기능을 구현해야 합니다.
//    //5. 필요하다면 클래스를 더 만들어도 상관 없습니다.
//    //클래스 Customer는 구입한 물건을 보관할 수 있습니다.
//    //      Customer는 물건 구입을 위한 돈을 가지고 있습니다.

//    //클래스의 관계를 표현하는 방식
//    //1. HAS-A : 포함(~는 ~를 가지고 있다.)
//    //2. IS-A : 상속(~는 ~이다.)
//    class Customer : Buy, Sell
//    {
//        public List<Product> products = new List<Product>();//클래스가 클래스를 가지고 있는 형태(has A)
//        public int money;//고객이 보유한 금액
//        public void buy(Product product) //물건 구매에 대한 기능(물건 1개 구매를 기준으로)
//        {
//            //1. 사용자의 금액이 물건 금액보다 적다면 구매 불가
//            if(money < product.price)
//            {
//                return;
//            }
//            money -= product.price;//가격만큼 금액 제거
//            products.Add(product);//보관함에 물건 추가
//            Console.WriteLine($"{product.name}을 구입했습니다!");
//        }
//        public void sell(Product product) //물건 판매에 대한 기능(물건 1개 판매를 기준으로)
//        {
//           if(product == null)
//            {
//                return;
//            }
//            money += product.sell_price;//판매 금액만큼의 money를 획득
//            products.Remove(product);
//            Console.WriteLine($"{product.name}을 판매했습니다!");
//        }
//    }
//    interface Buy
//    {
//        public void buy(Product product);
//    }
//    interface Sell
//    {
//        public void sell(Product product);
//    } 
//    class Product //물건
//    {
//        public string name;
//        public int price;//일반 가격(구매 가격)
//        public int sell_price;//판매 가격

//        public Product(string name, int price, int sell_price)
//        {
//            this.name = name;
//            this.price = price;
//            this.sell_price = sell_price;
//        }
//    }


//    internal class Class41
//    {
//        static void StartMenu(Customer customer, Product item)
//        {
//            Console.WriteLine("1. 물건 구매 ");
//            Console.WriteLine("2. 물건 판매 ");
//            Console.Write("진행하실 기능을 번호로 입력해주세요 >> ");
//            int select = int.Parse(Console.ReadLine());

//            switch(select)
//            {
//                case 1:
//                    //무엇을 구매할 것인가?
//                    //구매를 진행합니다.
//                    customer.buy(item);
//                    break;
//                case 2:
//                    //판매를 진행합니다.
//                    customer.sell(item);
//                    break;
//            }
//        }

//        static void Main(string[] args)
//        {
//            //고객이 물건 구매, 물건 판매의 기능을 선택하면 그 기능을 진행하도록 설계합니다.
//            Customer customer = new Customer();
//            customer.money = 10000;

//            Product banana_milk = new Product("바나나맛 우유", 1300, 620);

//            //물건 구매에 대한 코드 구현
//            StartMenu(customer,banana_milk);

//        }
//    }
//}
