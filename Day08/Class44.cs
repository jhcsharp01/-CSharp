//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Day08
//{
//    internal class Class44
//    {

//        static void Main(string[] args)
//        {
//            List<string> string_list = new List<string>()
//            {
//                "AA","BB","CC","DD","DD","CC","BB","AA"
//            };

//            var cutData = (from str in string_list
//                           select str).Distinct();
//            //Distinct()는 리스트에서 중복되는 값을 제거하고 고유한 값을 반환하는 기능

//            foreach (var str in cutData)
//            {
//                Console.WriteLine(str);
//            }


//        }
//    }
//}
