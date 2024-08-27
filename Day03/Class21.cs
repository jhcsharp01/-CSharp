//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //1. 접근 제한자(access modifier)
//    //해당 필드나 메소드 클래스 등의 접근 여부를 설정하는 키워드
//    //public : 모든 범위에서 공개 상태
//    //private : 자기 자신만 접근이 가능한 상태
//    //protected : 상속 관계까지의 접근을 허용합니다.
//    public class Item
//    {
//        //캡슐화(encapsulation)
//        //중요한 정보를 은닉하고, 기능으로 제공하는 것 
//        //데이터와 기능을 하나로 묶어서 설계
//        //핵심은 사용자에게 불필요한 내용을 전달하지 않도록 설계하는 것!

//        //장점 : 보안에 있어서 효과적인 코드
//        //       사용자 입장에서 쓰는데 어려움을 느끼지 않습니다.

//        //단점 : 개발 과정에서 핵심 개발자가 이탈했을 때 해독이 어렵습니다.
//        //       캡슐화 설계 과정에서 코드 자체가 단순하게 설계될 가능성이 높습니다.
//        private int id;
//        private string name;

//        //속성
//        //get : Id가 얻어오는 값
//        //set : Id가 값을 변경할 때 사용합니다.
//        //value : 수정할 값
//        public int Id { get => id; set => id = value; }
//        public string Name { get => name; set => name = value; }

//        public void ItemInfo()
//        {
//            Console.WriteLine($"{id}. {name}");
//        }
//    }
//    internal class Class21
//    {

//        static void Main(string[] args)
//        {
//            //클래스 인스턴스 생성
//            //인스턴스(instance) = 클래스를 기반으로 생성된 것
//            //레퍼런스(reference) = 객체, 참조 변수라고도 부릅니다.
//            //                     값이 아닌 주소를 가지고 있어 컴파일 시점에
//            //                     크기를 알 수 없습니다.

//            //클래스명 레퍼런스명 = new Item();
//            Item item = new Item();
//            item.Id = 1; //속성을 활용해 변수처럼 속성이 표현하고 있는 값을 수정할 수 있습니다.
//            item.Name = "바나나맛 우유";
//            Console.WriteLine(item.Id);
//            Console.WriteLine(item.Name);
 

//        }
//    }
//}
