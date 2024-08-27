using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.복습_파일
{
    //static을 붙이면 클래스명.필드값이나 클래스명.메소드명()으로 사용합니다.
    //단 이 경우 필드도 static이어야하고, 메소드도 static이어야 합니다.
    //클래스 자체로 작업이 가능해 클래스 변수(필드), 클래스 함수(메소드)라고 부릅니다.
    internal static class Tester
    {
        internal static int Tester_Method()
        {
            return 11;
        }

        //internal static Int32 Tester_Method()
        //{
        //    return 11;
        //}

    }
}
