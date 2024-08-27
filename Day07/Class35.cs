//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{

//    //C#의 데이터 형식
//    //Value :  bool , byte, int, float, char .....(기본 데이터)
//    //       + struct, enum
//    //값 그 자체로 사용합니다.
//    //값을 특정 메모리 공간에 대입해놓은 것
//    //공간을 확보하고 값을 대입해서 그 값을 그대로 사용만 하면 됩니다.

//    //Reference :   string
//    //              System.Array <- 코드에서 정의된 모든 배열( int[,] a , string[] a
//    //              class
//    //참조의 개념으로 사용합니다.
//    //특정 값이나 메모리 공간에 거쳐서 접근을 진행합니다. ex) person.value

//    internal class Class35
//    {
//        static void Method01(int a)
//        {
//            a += 10;
//        }
//        static int Method02(int a)
//        {
//            return a += 10;
//        }

//        //C#에는 매개변수 앞에 붙일 수 있는 키워드가 존재합니다.
//        //ref , out , in
//        //Pass by reference(참조에 의한 전달)를 구현할 때 사용합니다.

//        //ref : reference를 의미하며, 매개변수 앞에 붙으면 그 값은 reference로 보내게 됩니다.
//        //>> 매개변수의 값을 수정하면 밖의 실제 값에도 영향이 가게 됩니다.

//        //ref 키워드가 붙은 매개변수
//        static void Method03(ref int a)
//        {
//        //    int c = a;
//            a += 10;
//        }

//        //in 키워드가 붙은 매개변수
//        //해당 매개변수는 함수 내부에서 데이터를 읽는 용도로만 사용할 수 있습니다.
//        static void Method04(in int a)
//        {
//            int c = a; //in으로 받은 a는 읽어오는게 가능합니다.
//            //a = 10;//a를 쓰는 건 불가능합니다.
//        }

//        //out 키워드가 붙은 매개변수
//        //매개변수의 값을 반드시 초기화하도록 강제합니다.
//        static void Method05(out int a)
//        {
//            a = 30; //이 값은 외부의 값이 변경됩니다.
//        }
//        static void Main(string[] args)
//        {
//            int a = 10;
//            Console.WriteLine(a); 
//            Method01(a); //Pass by value(값에 의한 전달)
//            //문제점) 값만 전달해서 함수의 매개변수가 그 값을 복사해 별개의 값으로써 사용됨.
//            //그래서 함수 내부에서 값을 수정해도 밖의 원본이 바뀌는 일이 없습니다.
//            Console.WriteLine(a);
//            a = Method02(a);
//            Console.WriteLine(a);
//            Method03(ref a);//값을 전달할 때도 ref를 붙여서 해당 값을 레퍼런스화합니다.
//            Console.WriteLine(a);
//            //Method03을 호출하면 ref a가 매개변수 ref int a로 전달됩니다.
//            //내부에서 a는 10이 증가합니다. 이때 a는 ref이기 때문에 밖의 a도 10이 증가합니다.
//            //함수를 종료하면 매개변수 a는 소멸합니다.
//            //※ 함수 내부에서 값을 수정하면 함수 외부에서도 값이 바뀌는 것

//            int b = 7;
//            Method03(ref b); //ref로 사용되는 값은 초기화가 되어잇어야 합니다.

//            int c = 10;
//            Method04(c); //in 키워드를 따로 적지 않아도 작업 가능(READ-ONLY)
//            int d;
//            Method05(out d);//out 키워드에 대한 명시가 반드시 필요합니다.
//                            //ref와 다르게 선언한 값도 전달이 가능합니다(프로그램 내부에서 무조건 값이 변경되기 때문)
//            Console.WriteLine(d);
//        }
//        //ref와 in , out은 프로그래머들에게 의도를 알리고 잘못된 사용을 방지하기 위한 역할입니다.
//        //ref는 매개변수에 대한 읽기와 쓰기가 전부 가능합니다.(내부의 수정이 외부의 수정으로 이어집니다.)
//        //int은 매개변수에 대한 읽기만 가능합니다.(READ-ONLY)
//        //out은 매개변수에 대한 쓰기만 가능합니다.(WRITE-ONLY)(내부의 수정이 외부의 수정으로 이어집니다.)

//        //사용 목적?
//        //1. struct 변수가 커서 함수의 인자로 보내는게 부담스러운 상황
//        //2. 특정 레퍼런스 타입의 변수의 생성 자체를 함수 안에서 진행하는 경우
//        //3. (★★★) 함수로부터 여러 타입의 리턴 값을 받고 싶을 경우



//    }
//}
