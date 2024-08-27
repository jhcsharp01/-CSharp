//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Menu
//    {
//        public string name;
//        public string description;

//        public Menu(string name, string description)
//        {
//            this.name = name;
//            this.description = description;
//        }
//    }
    
//    internal class Class38
//    {
//        //메뉴의 이름을 전달하면 메뉴에 대한 설명이 출력되는 프로그램을 구현하고자 합니다.
//        //메뉴 입력하는 과정에서 메뉴의 이름이 없다면 메뉴를 입력해달라는 상황을 코드로 구현하시오.
//        //조건) 예외 처리를 이용하시오.
     
//        static void getMenu(Menu menu)
//        {
//            if(string.IsNullOrEmpty(menu.name)) //string의 문법 중 하나로 null 값이거나 비어있는지를 판단할 수 있습니다.
//            {
//                throw new Exception("이름을 제대로 입력해주세요!");
//            }
//            else
//            {
//                Console.WriteLine($"이 메뉴는 {menu.description}..");
//            }
//        }
//        static void Main(string[] args)
//        {
//            Menu ramen = new Menu("라멘", "육수를 푹 고아서 만든 일본식 중화요리입니다.");
//            Menu blank = new Menu("", "");

//            try
//            {
//                getMenu(ramen);
//                getMenu(blank);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }

//        }
//    }
//}
