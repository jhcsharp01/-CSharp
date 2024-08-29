//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class BaseClass { }
//    interface Iinterface { }

//    //1. T는 null을 허용하지 않는 값 형식의 타입
//    class GenericClass1<T> where T : struct
//    {
//    }
//    //2. T는 참조 형식이어야 합니다.
//    class GenericClass2<T> where T : class
//    {

//    }
//    //3. T는 public () 생성자가 존재해야 합니다.
//    //특징) 다른 제약 조건과 사용될 경우 이 조건이 항상 마지막에 지정됩니다.
//    class GenericClass3<T> where T : new()
//    {

//    }
//    //4. T는 BaseClass 또는 BaseClass를 상속받은 클래스여야 합니다.
//    class GenericClass4<T> where T : BaseClass
//    {

//    }
//    //5. T는 Iinterface 또는 Iinterface를 구현한 클래스
//    class GenericClass5<T> where T : Iinterface
//    {

//    }
//    //6. 제네릭의 제약 조건은 여러 개를 붙일 수 있습니다.
//    //단 기본적인 문법 체계의 법칙을 그대로 따릅니다.
//    //ex) struct는 null 허용을 안하게 설정되어 있어서 notnull을 붙일 수 없습니다.
//    //    struct는 값입니다. unmanaged는 참조 유형이 아니여야 한다는 조건입니다.
//    //    그런게 제약 조건이 겹치기는 하지만 다른 부분이 존재함.
//    //    unmanaged는 형식은 struct이면서 sbyte,byte,short,ushort...등 정해져있는 필드로 구성되어있어야 함.

//    //    클래스, 인터페이스를 조건으로 넣을 수 있습니다.(상속 + 인터 상속)
//    class GenericClass6<T> where T : BaseClass, Iinterface
//    {
//    }
//    class GenericClass7<T> where T : Enum
//    {

//    }    
//    internal class Class48
//    {
//        struct myStruct { }
//        enum MyEnum { }

//        class MyClass { }

//        static void Main(string[] args)
//        {
//            GenericClass1<int> genericClass1 = new GenericClass1<int>();
//            GenericClass1<float> genericClass2 = new GenericClass1<float>();
//            GenericClass1<myStruct> genericClass3 = new GenericClass1<myStruct>();
//            GenericClass1<MyEnum> genericClass4 = new GenericClass1<MyEnum>();
//            //GenericClass1<MyClass> genericClass5 = new GenericClass1<MyClass>();
//            //클래스는 레퍼런스이므로 넣을 수 없습니다.
//        }
//    }
//}
