//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    class Unit
//    {
//        //1. 클래스 return
//        public string name;
//        public string description;
//        private Unit(string name, string description)
//        {
//            this.name = name;
//            this.description = description;
//        }
//        public static Unit Instance = null;
//        //클래스 자신을 전역 변수로 가지고 있겟습니다.

//        //인스턴스의 생성을 진행
//        public static Unit GetInstance(string name, string description)
//        {
//            //유닛 생성
//            return new Unit(name, description); //생성자를 이용해 값을 넘김
//        }
//    }

//    internal class Example05
//    {
//        /// <summary>
//        /// int 배열에서 해당 데이터가 있는지 확인
//        /// </summary>
//        /// <param name="datas">배열</param>
//        /// <param name="search_data">값</param>
//        public static void Search(int[] datas, int search_data)
//        {
//            //1.전체 조사를 진행할 때는 foreach문을 활용합니다.
//            //2.인덱스로 조사를 진행할 경우에는 일반 for문을 활용합니다.(index 활용)
//            foreach (var data in datas)
//                //datas 묶음의 하나 하나를 data라고 표현
//                //var는 값의 형태에 따라 데이터 형태가 결정이 됩니다.
//                //var는 매개변수로는 쓸 수 없습니다.
//            {
//                if(data == search_data)
//                {
//                    Console.WriteLine("해당 데이터는 존재합니다.");
//                    return;
//                }
//                //함수 설계 시 return을 통해 작업을 종료할 수 있어서 else문을 따로 설계안하는 경우도 있음.
//                continue; //아닌 경우는 다 건너띔.              
//            }
//            Console.WriteLine("해당 데이터는 존재하지 않습니다.");
//        }

//        public static void Search2(int[] datas, int search_data)
//        {

//            for (int i = 0; i < datas.Length; i++)
//            {
//                if (datas[i] == search_data)
//                {
//                    Console.WriteLine("해당 데이터는 존재합니다.");
//                    return;
//                }
//                continue;
//            }
//            Console.WriteLine("해당 데이터는 존재하지 않습니다.");
//        }

//        //요소로 2차원 배열이 들어가는 경우
//        //int [,]
//        public static void PrintArray2(int[,] arrays)
//        {
//            for (int i = 0; i < arrays.GetLength(0); i++) //1번째 배열
//            {
//                for (int j = 0; j < arrays.GetLength(1); j++)//2번째 배열
//                {
//                    Console.WriteLine(arrays[i, j].ToString());
//                }
//            }
//        }
//        public static void PrintArray22(int[,] arrays)
//        {
//            foreach(var inner_array in arrays) //배열 안에 있는 배열을 조사합니다.
//            {
//                Console.WriteLine(inner_array.ToString());
//            }
//            //이런 식의 설계는 순회 자체는 코드가 매우 간단해서 효과적이지만
//            //for문과 다르게 각각의 인덱스에 대한 작업이 힘들어짐.
//        }
//        public static void Main(string[] args)
//        {
//            Unit u = Unit.GetInstance("햄스터", "쓸만한 유닛이다.");
//            Console.WriteLine(u.name);
//            Console.WriteLine(u.description);
//            Search([1, 2, 3, 4, 5], 1);
//            Search2([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 11);
//            int[,] iArray2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
//            PrintArray22(iArray2);

//            //매개변수로 어떤 데이터가 들어오든 그 데이터에 맞게 일반 작업을 진행하면
//            //자연스럽게 작업은 진행이 될 것입니다.
//            //단 값 전달 등은 call by reference 같은 것들을 고려해볼 필요는 있겠습니다.
//        }

//    }
//}
