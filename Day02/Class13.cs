//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class13
//    {
//        static void Main(string[] args)
//        {
//            //배열과 반복문
//            //배열 : 같은 타입의 데이터를 묶어서 순서대로 정렬한 자료구조
//            //인덱스 : 배열에 있는 특정 값이 있는 위치를 알려주는 정수형 데이터
//            //         0번부터 배열의 길이 -1까지의 범위를 가지게 됩니다.
//            //특이사항) 파이썬의 경우는 음수번호 존재 (-1이 가장 마지막 값)
//            //요소   : 배열 안에 있는 값 그 자체

//            //배열 선언
//            //자료형[] 배열명 = new 자료형[배열의 길이];
//            int[] arrays = new int[10];
//            int value = 0; //배열에 넣어줄 값

//            //배열에 1부터 10까지의 숫자를 순서대로 넣겠습니다.
//            //배열 관련 작업 시 초기식은 0으로 잡아주세요.(인덱스)
//            for (int i = 0; i < arrays.Length; i++)
//            {
//                arrays[i] = value++;
//                //arrays[0] = 1;   value -> 2
//                //arrays[1] = 2;   value -> 3
//                Console.WriteLine($"arrays[{i}] = {value}");
//            }
//            //부록) ++ 연산자의 사용 방법
//            // a++, ++a와 같이 ++는 앞에도 뒤에도 붙을 수 있는 특수한 연산자
//            //전열(++a)는 a의 값을 우선적으로 1을 더하고, 이후에 연산을 진행합니다.
//            //후열(a++)는 연산을 진행하고 그 후에 a의 값을 1 증가
//            int a = 10;
//            int b = a++ + 5 + ++a;
//            // a++ + 5 -> 15 a -> 11
//            // 5 + ++a -> a -> 12  15 + 12 = 27 
//            Console.WriteLine(a); // 12
//            Console.WriteLine(b); // 27

//            //1부터 100까지의 숫자 중에서 2의 배수에 해당하는 값만 배열로 표현
//            //풀이)1. 1부터 100까지의 숫자 중 2의 배수가 몇 개인지 확인
//            int count = 0;
//            for (int i = 1; i <= 100; i++)
//            {
//                if (i % 2 == 0)
//                    count++;
//            }
//            Console.WriteLine(count);
//            //2. 그 개수를 기반으로 배열 생성
//            int[] array2 = new int[count];
//            //3. 시작 값 설정
//            int start = 2;
//            //4. 반복문을 통해 값 추가
//            for (int i = 0; i < array2.Length; i++)
//            {
//                array2[i] = start;
//                start += 2;
//                Console.Write(array2[i] + " ");
//            }
//        }
//    }
//}
