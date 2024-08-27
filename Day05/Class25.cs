//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //클래스 상속
//    //객체지향 프로그래밍 설계 방식 중 하나입니다.
//    //객체 지향 프로그래밍 설계 방식 1. 캡슐화 2. 상속 3. 추상화 4. 다형성

//    //기존의 클래스를 이용해서 새로운 클래스를 만들어주는 기능
//    //기존 클래스로부터 기능을 물려받아 사용이 가능합니다.

//    //상속 설계의 목적
//    //1. 개체 간의 계층적인 구조를 설명하기 위한 설계
//    //2. 개체 중에서 비슷한 기능이 많은 것들을 대상으로 중복 설계 피할 수 있음.
//    //Visual Studio의 클래스 디자이너 도구를 통해 보면 쉽게 계층 구조를 볼 수 있습니다.
//    //상속 사용 방법
//    //class 새로만들클래스명 : 기존클래스명
//    class Animal
//    {
//        public string name;
//        public string description;

//        public void Cry()
//        {
//            Console.WriteLine("동물 울음 소리");
//        }
//    }
//    class Tiger : Animal { }    
//    class Unit_Hero
//    {
//        protected int hp;
//        public string name;
//        private int atk;
//    }
//    class Knight : Unit_Hero{}
//    class Archor : Unit_Hero{}
//    class Mage : Unit_Hero{}
//    class MasterKnight : Knight{}
//    class Warrior : Knight{}

//    class MasterArchor : Archor { }
//    class Ranger : Archor{}
//    class Wizzard : Mage { }
//    class Sorceror : Mage { }




//    internal class Class25
//    {
//        static void Main(string[] args)
//        {
//            Tiger tiger = new Tiger();
//            tiger.Cry();
//            tiger.name = "호랑이";
//            tiger.description = "커다란 호랑이입니다.";
//            Console.WriteLine(tiger.name);
//            Console.WriteLine(tiger.description);
//        }
//    }
//}
