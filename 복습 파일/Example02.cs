//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    public enum Specific   
//    {
//        반감,약점,무효
//    }
//    public enum Type
//    {
//        불,독,얼음,전기
//    }
//    public struct Item
//        //사용자가 하나의 이름으로 여러 개의 데이터를 관련있게 표현하기 위한 사용자 정의 타입
//        //ex) 아이템의 이름, 아이템의 설명 -> struct Item의 name
//    {
//        public string name;
//        public string description;

//        //구조체의 생성을 편하게 하기 위해 생성자를 만들어줍니다.
//        public Item(string name) : this()
//        {
//            this.name = name;
//        }
//    }
//    // 클래스(class) vs 구조체(struct)
//    //둘은 사용 방식도, 용도도 비슷해서 다음 상황에 따라 결정합니다.

//    //1. 상속의 여부
//    //struct는 상속이 불가능합니다. class는 상속이 가능합니다.

//    //2. 프로그램 내에서 해당 데이터에 대한 취급 여부
//    //struct는 Value Type, class는 Reference Type입니다.
//    // >> 값의 경우 스택(메모리 영역)에 할당됩니다.
//    // >> 참조의 경우 힙(동적 메모리 영역)에 할당한 값의 주소를 가지고 있습니다.

//    //C#의 가비지 컬렉터(GC)
//    //C#은 내부에 힙에서 할당된 메모리 중 사용하지 않은 애들을 자동으로 제거해주는
//    //GC가 존재합니다.
//    //프로그램이 알아서 작업을 하기에 신경쓰지 않아도 되나, 언제 제거되는지를 정확히
//    //알 수가 없어서 프로그램의 동작 속도가 느려지거나 멈추는 상황이 발생할 수 도 있음.
//    //스택의 경우는 사용 후에 알아서 종료,제거되는 방식
//    //단 스택의 경우는 스택 자체의 메모리 제한으로 인해 지속적인 호출이
//    //스택 오버플로우 현상으로 벌어질 위험이 있습니다.
//    //따라서 굳이 힙에 할당하지 않아도 되는 데이터는 스택 메모리에서 사용을 하면
//    //프로그램 속도 향상에 도움을 줄 수 있습니다.

//    //어떤 상황에 구조체를 쓰는게 좋은가?(다음 경우에는 구조체로 만들지 마세요.)
//    //1. 변경할 수 없는 데이터의 구현
//    //2. 인스턴스의 크기가 16 바이트 미만일 경우에는 구조체로 만들지 않습니다. 
//    //3. 단일 값에 대한 표현

//    //결론 : 복잡한 데이터 -> class , 임시 데이터 : struct

//    //클래스 만들고 사용해보기
//    //1. 클래스 이름을 지어줍니다.(프로그램의 핵심이 되는 데이터의 이름)
//    class Monster
//    {
//        //2. 클래스가 표현할 정보를 작성해줍니다.(멤버)
//        //2-1. 클래스로 만들 데이터가 가질 데이터
//        //    >> 개체의 속성을 표현하는 기능
//        public string name; //몬스터의 이름
//        public int level;
//        public int hp;
//        public int money;
//        public Specific specific;
//        public Type type;
//        public Item[] item; //몬스터가 가지고 있는 아이템 묶음

//        //2-2.메소드
//        //    클래스로 만들 데이터가 할 수있는 기능/동작
//        //    클래스 내에서 명령문을 넣어주는 위치
//        public void Info()
//        {
//            Console.WriteLine($"이름 : {name}");
//            Console.WriteLine($"레벨 : {level}");
//            Console.WriteLine($"체력 : {hp}");
//            Console.WriteLine($"드랍 금액 : {money}");
//            Console.WriteLine($"특징 : {type} {specific}");
//            ShowDropTable();
//        }

//        //Info 함수를 사용하면 ShowDropTable()을 호출할 수 있고
//        //따로 ShowDropTable()을 작업할 필요가 없다면 private로 막아줍니다.
//        //※ 서로 연관되어있는 속성과 동작들을 하나로 묶어놓아서 데이터를 외부에서
//        //보호하는 설계 방식 - Encapsulation(캡슐화)
//        //목적 : 1. 중요한 데이터 외부 노출 방지 목적
//        //       2. 불필요한 코드 비공개로 사용자가 쓰기 편하게 함.
//        //       3. 코드 공개로 인한 혼란 방지

//        private void ShowDropTable()
//        {
//            foreach (var item_data in item)
//                Console.WriteLine(item_data.name);
//        }
//    }


//    internal class Example02
//    {
//        static void Main(string[] args)
//        {
//            //1. 클래스 인스턴스(instance) 생성과 초기화
//            //인스턴스는 클래스의 형태로 생성한 내용물
//            Monster monster = new Monster()
//            {
//                //필드의 이름 = 값을 적어주면 해당 값에 대한
//                //초기화가 진행됩니다.
//                name = "달팽이",//이름
//                level = 1, //레벨
//                hp = 8, //체력
//                money = 4, //금액
//                specific = Specific.반감,//특성
//                type = Type.독, //타입
//                item = new Item[] 
//                { new Item("달팽이의 껍질"),
//                  new Item("빨간 포션"),
//                  new Item("투구 방어력 주문서 10%"),
//                  new Item("망토 마법방어력 주문서 60%"),
//                  new Item("활전용 화살"),
//                  new Item("청동의 원석"),
//                  new Item("가넷의 원석"),
//                  new Item("석궁전용 화살"),
//                  new Item("연두색 머리띠"),
//                  new Item("초록사과"),           
//                } //배열
//            };

//            //인스턴스를 통해 메소드 사용
//            monster.Info();

//            //2. 클래스의 생성 후 인스턴스의 초기화
//            Monster monster2 = new Monster();

//            monster2.name = "다크 스텀프";
//            monster2.level = 1;
//            monster2.hp = 250;
//            monster2.money = 20;
//            monster2.specific = Specific.약점;
//            monster2.type = Type.불;
//            monster2.item = 
//                [ new Item("나뭇잎"),
//                  new Item("빨간 포션"),
//                  new Item("장갑 민첩성 주문서 10%"),
//                  new Item("사각 나무 방패"),
//                  new Item("브론즈 캡"),
//                  new Item("폴암"),
//                  new Item("옐로우 아벨린"),
//                  new Item("옐로우 아벨린 치마"),
//                  new Item("그린 아리안느"),
//                  new Item("그린 아리안느 치마"),
//                ];
//            monster2.Info();

//        //두 방식 모두 인스턴스에 대한 작업을 진행하는 것으로, 접근 제한자에 영향을 받습니다.
//        //필드가 private라면 검색 불가
//        }
//    }
//}
