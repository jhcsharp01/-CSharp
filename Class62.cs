//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class TestClass
//    {
//        public int fieldA;
//        public float fieldB;
//        private bool fieldC;
//    }

//    internal class Class62
//    {
//        static void Main(string[] args)
//        {
//            //클래스로부터 필드에 대한 검색을 진행하는 코드
//            var obj01 = new TestClass();
//            Console.Write("검색할 필드를 입력해주세요 >> ");
//            string name = Console.ReadLine();

//            //한개 검색
//            var fieldInfo =obj01.GetType().GetField(name,System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

//            //전체 검색
//            var fieldsInfo = obj01.GetType().GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

//            foreach (var field in fieldsInfo)
//            {
//                Console.WriteLine(field.Name);
//            }
//            if (fieldInfo != null)
//                Console.WriteLine($"검색한 필드 : {fieldInfo.Name}");
//            else
//                Console.WriteLine("Can not Found!");
//        }
//    }
//}
