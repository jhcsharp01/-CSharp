//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Sample<T>
//    {
//        public T Value { get; set; }
//        //자동 구현 프로퍼티
//        //컴파일러가 필드를 자동으로 생성하고
//        //get,set도 자동으로 처리합니다.
//    }
//    public class SClass<T> where T : class
//    {
//        private T _value;
//        public SClass(T value)
//        {
//            _value = value;
//        }
//        public T GetValue()
//        {
//            return _value;
//        }
//        public void SetValue(T value)
//        {
//            _value = value;
//        }
//        public void Print()
//        {
//            Console.WriteLine(GetValue().ToString());
//        }
//    }
//    //더하기를 진행할 때 int , float를 대상으로만 더하기 기능을 제공하고 싶습니다.
//    public class AddClass<T> where T : struct
//    {
//        //매개 변수 2개를 대상으로 더하기를 진행합니다.
//        public T Add(T x, T y)
//        {
//            //T의 타입이 int 타입이라면
//            if(typeof(T) == typeof(int))
//            {
//                return (T)(object)((int)(object)x + (int)(object)y);
//                //x와 y의 타입이 정해지지 않았기에 모든 타입인 object로 변환
//                //그 후 object를 int로 변환
//            }
//            //T의 타입이 float 타입이라면
//            else if (typeof(T) == typeof(float))
//            {
//                return (T)(object)((float)(object)x + (float)(object)y);
//                //x와 y의 타입이 정해지지 않았기에 모든 타입인 object로 변환
//                //그 후 object를 int로 변환
//            }
//            else
//            {
//                //전달받은 값이 제대로 된 값이 아님을 알려줘야 합니다.
//                throw new ArgumentException("이건 우리가 설정한 타입이 아닙니다.");
//            }
//        }
//    }
//    internal class Class49
//    {
//        static void Main(string[] args)
//        {
//            Sample<string> sample = new Sample<string>();
//            sample.Value = "test";
//            Console.WriteLine(sample.Value);
//            Sample<int> sample2 = new Sample<int>();
//            sample2.Value = 1;
//            Console.WriteLine(sample2.Value);

//            SClass<string> sClass = new SClass<string>("안녕하세요~");
//            sClass.Print();

//            AddClass<double> string_add_class = new AddClass<double>();
//            //double result = string_add_class.Add(1.0, 2.0);
//            //실행해보면 double에 대한 설정을 안해놨기 때문에 예외 발생

//            AddClass<float> string_add_class1 = new AddClass<float>();
//            float result2 = string_add_class1.Add(1.0f, 2.0f);
//            Console.WriteLine(result2);
//        }

//    }
//}
