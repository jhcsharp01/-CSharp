//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //다음 조건의 클래스를 구현하시오.
//    //1. Customer 클래스
//    //   고객 모두가 적용되는 혜택
//    //   고객의 아이디, 고객의 이름, 보너스 포인트, 적립 비율
//    //   Customer의 등급은 'Bronze'이며, 물품 구매 시 1%의 보너스 포인트
//    //   가 적립됩니다.
//    class Customer
//    {
//        protected int id; //아이디를 번호로 하거나, 문장으로 표현
//        protected string name;
//        protected int bonus_point;
//        protected float bonus_rate;
//        protected string rank;
//        public Customer(int id, string name, int bonus_point)
//        {
//            this.id = id;
//            this.name = name;
//            this.bonus_point = bonus_point;
//            bonus_rate = 0.01f;
//            rank = "Bronze";
//        }
//        //물건 구매
//        public virtual int buy(int price)
//        {
//            bonus_rate += price * bonus_rate;
//            return price;
//        }
//        public override string? ToString()
//        {
//            return $"Customer의 등급은 {rank}이며, 물품 구매 시 {bonus_rate :##.#%} 보너스 포인트가 적립됩니다.";
//        }
//    }
//    class SCustomer : Customer
//    {
//        public SCustomer(int id, string name, int bonus_point) : base(id, name, bonus_point)
//        {
//            bonus_rate = 0.03f;
//            rank = "SILVER";
//        }
//    }
//    class VIPCustomer : Customer
//    {
//        public VIPCustomer(int id, string name, int bonus_point) : base(id, name, bonus_point)
//        {
//            bonus_rate = 0.05f;
//            rank = "VIP";
//        }
//        public override int buy(int price)
//        {
//            bonus_rate += price * bonus_rate;
//            price = price * (9/10);
//            return price;
//        }
//    }
//    //2. SCustomer 클래스
//    //   Customer 클래스와 속성이 동일합니다.
//    //   SCustomer의 등급은 'SILVER'이며, 물품 구매 시 3%의 보너스 포인트가 적립됩니다.

//    //3. VIPCustomer 클래스
//    //   Customer 클래스와 속성이 동일합니다.
//    //   VIPCustomer의 등급은 'VIP'이며, 물품 구매 시 5%의 보너스 포인트가 적립됩니다.
//    //   구매에 있어서 10%의 할인을 받습니다.
//    //   안내 서비스가 따로 존재합니다.
//    internal class Class27
//    {
//        static void Main(string[] args)
//        {
//            //Customer의 등급을 고르면, 해당 Customer에 대한 혜택이 출력되도록 코드를 작성합니다.
//            Customer c = new Customer(1, "유람", 0);
//            Console.WriteLine(c.ToString());
//        }
//    }
//}
