//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////제네릭(Generic)
////일반화 프로그래밍
////데이터의 형식을 일반화하여 사용할 수 있게 해주는 기능

//namespace ConsoleApp1
//{
//    class GenericClass<T> //클래스 사용 시 타입을 작성
//    {
//        public T value;

//        public T getValue()
//        {
//            return value;
//        }
//        public void setValue(T value)
//        { 
//        this.value = value; 
//        }
//    }


//    internal class Class47
//    {
//        static void PrintArrayInt(int[] arrays)
//        {
//            for (int i = 0; i < arrays.Length; i++)
//            {
//                Console.Write(arrays[i] + " ");
//            }
//            Console.WriteLine();
//        }
//        static void PrintArrayFloat(float[] arrays)
//        {
//            for (int i = 0; i < arrays.Length; i++)
//            {
//                Console.Write(arrays[i] + " ");
//            }
//            Console.WriteLine();
//        }
//        static void PrintArrayBool(bool[] arrays)
//        {
//            for (int i = 0; i < arrays.Length; i++)
//            {
//                Console.Write(arrays[i] + " ");
//            }
//            Console.WriteLine();
//        }

//        //위에 있는 방식은 너무 같은 코드를 많이 만들게 됨.
//        //모든 타입의 조상인 object를 통해 코드 통일화
//        static void PrintArray(object[] arrays)
//        {
//            for (int i = 0; i < arrays.Length; i++)
//            {
//                Console.Write(arrays[i] + " ");
//            }
//            Console.WriteLine();
//        }
//        //이 방식은 값을 사용하는 데에는 어려움이 있음.
//        //각 데이터에 변형을 줘야하는 부분 등이 존재하기 때문

//        //이제는 <T>를 넣어서 T를 타입 대신 작성합니다.
//        //함수를 사용할 때 <T> 자리에 사용할 타입을 작성하는 것으로 그 타입에 대한 처리로
//        //만들어줍니다. - 제네릭
//        //C++ 에서는 템플릿, 자바 , C# 제네릭
//        static void PrintArrayG<T>(T[] arrays)
//        {
//            for (int i = 0; i < arrays.Length; i++)
//            {
//                Console.Write(arrays[i] + " ");
//            }
//            Console.WriteLine();
//        }
//        //제네릭의 장점 : 타입에 따라 코드를 자동으로 만들고 문법을 적용시켜
//        //               불필요한 중복적인 코드 설계를 피할 수 있습니다.

//        static void Main(string[] args)
//        {
//            PrintArray([1, 2, 3, 4, 5]);
//            PrintArray(['a', 2, "bc", true, 5.4]);
//            PrintArrayG<int>([1, 2, 3, 4, 5]);
//            //PrintArrayG<int>(['a', 2, "bc", true, 5.4]); //타입에 맞지 않는 값을 넣으면 오류 체크
        
//            GenericClass<int> genericClass = new GenericClass<int>();
//            genericClass.setValue(1);
//            Console.WriteLine(genericClass.getValue());
//            GenericClass<string> genericClass2 = new GenericClass<string>();
//            genericClass2.setValue("Hello");
//            Console.WriteLine(genericClass2.getValue());
//            GenericClass<float> genericClass3 = new GenericClass<float>();
//            genericClass3.setValue(1.5f);
//            Console.WriteLine(genericClass3.getValue());
//        }

//    }
//}
