//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////인터페이스 예제

//namespace ConsoleApp1
//{
//    //아이템에서 분류할 타입에 대한 표현
//    enum Type
//    { 
//        Weapon,Armor,Accesary,Potion
//    }
//    //인터페이스 설계
//    //C#에서는 인터페이스 이름 맨 앞에 I를 붙여주는게 암묵적인 룰입니다.(이게 인터페이스인지 빠르게 확인하기 위함)
//    interface IUsable
//    {
//        public void Use(); //사용했을 때 발생하는 기능
//        public void Use(int count);//아이템 개수를 가지고 사용했을 때 발생하는 기능
//    }
//    interface IEquipable
//    {
//        public static int level_cost; //레벨 제한
//        public static int str_cost; //힘 제한
//        public static int dex_cost; //민첩 제한
//        public void Equip(); //장착 시 발생하는 기능
//    }
//    interface IThrowable
//    {
//        public void Throw(int count);
//    }
//    interface ICountable
//    {
//        public static int count;
//    }
    


//    //아이템에 대한 공통 정보
//    class Item
//    {
//        public int id; //아이템의 고유 식별 번호
//        public string? name; //아이템의 이름
//        public string? description;//아이템의 설명
//        public Type type; //아이템의 유형
//    }

//    class Weapon : Item
//    {

//    }
//    class Accesary : Item
//    {
//    }
//    class Potion : Item
//    {
//    }
//    class Armor : Item
//    {
//    }

//    //엘릭서 : 셀 수 있고 사용 가능한 포션
//    class Elixer : Potion, ICountable, IUsable
//    {
//        public int point;
//        public void Use()
//        {
//            Console.WriteLine("체력이 전부 회복됬습니다.");
//        }
//        public void Use(int count)
//        {
//            Console.WriteLine($"아이템을 1개 사용했습니다. 남은 아이템 수 {count}");
//            Console.WriteLine($"+ {point}만큼 회복합니다.");
//            Console.WriteLine("체력이 전부 회복됬습니다.");
//        }
//    }
//    class firebomb : Potion, ICountable, IThrowable
//    {
//        public int damage;
//        public void Throw(int count)
//        {
//            Console.WriteLine($"{name}을 던졌습니다!");
//        }
//    }




//    internal class interExample
//    {
//    }
//}
