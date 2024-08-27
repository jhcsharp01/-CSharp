//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.복습_파일
//{
//    class Food
//    {
//        private string name;
//        private int price;
//        //생성자
//        //클래스를 생성할 때 호출할 메소드입니다.
//        //클래스 내부의 기능으로, 필드를 private로 써도 만들 수 있습니다.
//        public Food(string name, int price)
//        {
//            this.name = name;
//            this.price = price;
//        }
//        //소멸자
//        //클래스 객체가 삭제되는 상황에 호출되는 메소드입니다.
//        //C#에서 GC에 의해 소멸이 진행되기 때문에 따로 설계할 필요는 없습니다.
//        ~Food()
//        {
//            Console.WriteLine($"{name}이(가) 소멸했습니다.");
//        }
//    }
//    //일반적으로는 GC가 자동으로 리소스를 해제하기 때문에 상황을 알 수 없음.
//    //명시적으로 해제할 수 있도록 IDisposable 인터페이스를 제공해주고 있습니다.
//    class A : IDisposable
//    {
//        private bool disposedValue;
//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposedValue)
//            {
//                if (disposing)
//                {
//                    Console.WriteLine("개체가 삭제되었습니다.");
//                    // TODO: 관리형 상태(관리형 개체)를 삭제합니다.
//                }
//                // TODO: 비관리형 리소스(비관리형 개체)를 해제하고 종료자를 재정의합니다.
//                // TODO: 큰 필드를 null로 설정합니다.
//                disposedValue = true;
//            }
//        }
//        // // TODO: 비관리형 리소스를 해제하는 코드가 'Dispose(bool disposing)'에 포함된 경우에만 종료자를 재정의합니다.
//        // ~A()
//        // {
//        //     // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
//        //     Dispose(disposing: false);
//        // }
//        public void Dispose()
//        {
//            // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
//            Dispose(disposing: true);
//            GC.SuppressFinalize(this); //GC에 의해 자원을 해제합니다.
//        }
//    }
//    internal class Example03
//    {
//        static void Main(string[] args)
//        {
//            Food food = new Food("기본김밥",3000); //인스턴스 생성 시에 값을 넣어주면 필드의 값이 초기화됩니다.
//            A a = new A();
//            a.Dispose();
//            //GC.Collect(); //가비지 콜렉터로 수집을 진행합니다.
//        }
//    }
//}
