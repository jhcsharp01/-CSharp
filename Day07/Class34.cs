//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //2차원 배열
//    //배열 안의 요소로 배열이 들어있는 자료구조

//    //선언 방법
//    //자료형 [,] = new 자료형[세로열,가로열];


//    //도전 과제)(일반) -zigzag
//    // 1  2  3  4  5
//    //10  9  8  7  6
//    //11 12 13 14 15

//    //(전공자) - snail
//    // 1  2  3  4 5
//    //16 17 18 19 6
//    //15 24 25 20 7
//    //14 23 22 21 8
//    //13 12 11 10 9


//    internal class Class34
//    {
//        static void Main(string[] args)
//        {
//            int[,] array = new int[3 , 3]; //가로 3, 세로 3 배열 생성   

//            //number1을 각 배열의 위치에 초기화하는 코드
//            int number = 1;
//            for(int i = 0; i < 3; i++)
//            {
//                for(int j = 0; j < 3; j++)
//                {
//                    array[i,j] = number++;
//                }
//            }

//            //배열 출력
//            for (int i = 0; i < array.GetLength(0); i++)
//            {
//                for(int j = 0; j < array.GetLength(1); j++)
//                {
//                    Console.Write(array[i,j] + " ");
//                }
//                Console.WriteLine();
//            }

//            int[,] array2 = new int[2, 14];
//            //GetLength(int dimension);  dimension : 0부터 배열의 차원 수 -1까지의 index
//            Console.WriteLine("행의 길이 :" + array2.GetLength(0)); //2차원 배열의 행의 길이를 return
//            Console.WriteLine("열의 길이 : " + array2.GetLength(1)); //2차원 배열의 열의 길이를 return
//            Console.WriteLine("배열이 가지는 요소의 총 개수 : " + array2.Length);

//            //Clone
//            int[,] clone_array = (int[,])array.Clone();
//            int[,] clone_array2 = array;

//            for (int i = 0; i < clone_array.GetLength(0); i++)
//            {
//                for (int j = 0; j < clone_array.GetLength(1); j++)
//                {
//                    Console.Write(clone_array[i, j] + " ");
//                }
//                Console.WriteLine();
//            }

//            for (int i = 0; i < clone_array2.GetLength(0); i++)
//            {
//                for (int j = 0; j < clone_array2.GetLength(1); j++)
//                {
//                    Console.Write(clone_array2[i, j] + " ");
//                }
//                Console.WriteLine();
//            }


//            //for문을 이용해서 1부터 9까지의 숫자를 넣어 3 x 3의 배열을 만들려고 합니다.
//            //출력을 진행했을 경우 다음과 같도록 배열에 값을 넣어주세요.

//            // 배열 값    인덱스
//            //1 6 7     00 01 02 
//            //2 5 8     10 11 12 
//            //3 4 9     20 21 22 

//            //처음 시작 시 아래로 값 증가 (뒤에 있는 인덱스가 짝수인 경우)
//            //다음 시작 시 위로 값 증가   (뒤에 잇는 인덱스가 홀수인 경우)
            

//            //힌트) 배열의 값 1은 배열명[0][0]입니다.
//            //      배열의 값 2는 배열명[1][0]입니다.
//            //      배열의 값 5는 배열명[1][1]입니다.

//            int[,] array3 = new int[3, 3]; //1. 배열 생성

//            int value = 1; //시작할 값

//            //인덱스 조작
//            for (int i = 0; i < array3.GetLength(0); i++)
//            {
//                if(i % 2 == 0)
//                {
//                    //짝수일 경우 아래로 값 증가하도록 설계
//                    for (int j = 0; j < array3.GetLength(1); j++)
//                    {
//                        array3[j, i] = value++; //00 -> 10 -> 20
//                    }
//                }
//                else
//                {
//                    for (int j = array3.GetLength(1)-1; j >= 0; j--)
//                    {
//                        array3[j, i] = value++; //00 -> 10 -> 20
//                    }
//                }
//              }
//            //일반 출력
//            for (int i = 0; i < array3.GetLength(0); i++)
//            {
//                for (int j = 0; j < array3.GetLength(1); j++)
//                {
//                    Console.Write(array3[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
