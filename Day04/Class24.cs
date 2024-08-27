//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace ConsoleApp1
//{
//    //컬렉션 : 여러 개의 데이터를 저장 및 삭제, 삽입 등 다양한 기능들을
//    //         관리하는 기능을 가진 자료 구조들을 의미합니다.

//    //컬렉션 : ArrayList
//    //ArrayList는 List 컬렉션을 통해 만들어진 컬렉션입니다.

//    internal class Class24
//    {
//        static void Main(string[] args)
//        {
//            ArrayList name_list = new ArrayList();
//            //ArrayList 생성
//            name_list.Add("김기영"); //Add를 통해 추가가 가능합니다.
//            name_list.Add("홍길동"); //ArrayList에 넣을 수 있는 형태의 데이터는 object?
//            name_list.Add("김철수"); //object는 모든 데이터 형태의 윗 단계
//            name_list.Add("유하나"); //자료형?은 해당 값에 접근하기 전에 해당 객체가 null인지 확인합니다.                            
//            name_list.Add("이현우"); //객체가 null이면 null 자체를 return, 아니면 지정된 멤버를 리턴합니다.
//            name_list.Add(true); 
//            name_list.Add(1); 
//            name_list.Add(10.5f); 
//            //foreach문을 사용해 배열리스트 전체를 처리합니다.
//            //foreach(자료형 변수명 in 묶음)
//            //{
//            //  작업할 명령문;
//            //}
//            //묶음 내부에 잇는 하나하나의 자료형을 대상으로 반복 작업을 진행하는 foreach문
//            //주로 컬렉션 사용 시 많이 사용됩니다.
//            foreach(object obj in name_list)
//            {
//                Console.WriteLine(obj.ToString());
//            }

//            //2) List<T>
//            //List<T> 리스트명 = new List<T>();
//            //T는 넣어줄 타입을 의미합니다.
//            List<string> item_list = new List<string>();
//            item_list.Add("목도");
//            item_list.Add("활");
//            item_list.Add("목도");
//            item_list.Add("활");
//            //item_list.Add(10);

//            item_list.Remove("목도");

//            foreach(string obj in item_list)
//            {
//                Console.WriteLine(obj); 
//            }


//            //List<T>를 더 많이 활용할 것입니다.
//            //이유 1. 타입에 대한 설정 가능
//            //       <T> 위치에 타입을 넣었을 경우
//            //       그 형태의 데이터만 작업할 수 있습니다.
//            //이유 2. 잘못된 값을 넣었을 경우에도 바로 확인 가능
//            //        위의 ArrayList는 실행해보지 않는 이상은 잘못된 값인지
//            //        모릅니다.(컴퓨터가)
//            //이유 3. 한번 만들면, 수정이 불가능한 값 '배열'과 다르게
//            //        데이터를 코드를 통해 추가, 삭제, 삽입이 가능합니다.
//        }
//    }
//}
