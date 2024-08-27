//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    abstract class Converter
//    {
//        protected float ratio;
//        protected abstract float convert(float src);
//        protected abstract string Getstring();
//        protected abstract string Getstring2();
//        public void Run()
//        {
//            Console.WriteLine($"{Getstring()} -> {Getstring2()}");
//            Console.Write($"{Getstring()}를 입력해주세요 >> ");
//            float value = float.Parse(Console.ReadLine());
//            float result = convert(value);
//            Console.WriteLine($"변환 결과 : {result} {Getstring2()}입니다.");
//        }
//    }
//    class W2D : Converter
//    {
//        //1.생성자 수정
//        public W2D(float ratio)
//        {
//            this.ratio = ratio;
//        }
//        //2. 오버라이딩 작업 마무리
//        protected override float convert(float src)
//        {
//            return src / ratio;
//        }
//        protected override string Getstring()
//        {
//            return "원";
//        }
//        protected override string Getstring2()
//        {
//            return "달러";
//        }
//    }

//    //abstract class를 상속해서 자식 클래스를 만들면
//    //빠르게 형태를 잡아 구현할 수 있다.

//    internal class Class30
//    {
//        //아래에 있는 실행 결과를 참고하여 클래스 W2D를 구현합니다.
//        static void Main(string[] args)
//        {
//            W2D wtd = new W2D(1400);
//            wtd.Run();
//            //원 -> 달러
//            //원을 입력해주세요 >> 28000
//            //변환 결과 : 20 달러입니다.
//        }
//    }
//}
