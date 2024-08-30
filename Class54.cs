//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApp1
//{
//    //LINQ: 배열 또는 리스트 등의 컬렉션 데이터를 반복문과 조건문으로 쉽게
//    //      구할 수 있습니다.
//    //LINQ의 확장 메소드
//    //1. Sum() : 숫자 배열 또는 컬렉션의 합
//    //2. Count() : 숫자 배열 또는 컬렉션의 개수
//    //3. Average() : 숫자 배열 또는 컬렉션의 평균
//    //4. Max() : 최대값
//    //5. Min() : 최소값

//    //6. Where(조건문) : 조건에 맞는 IEnumerable<T> 형태의 데이터를 가져옵니다.
//    //7. ToList() : Where문 뒤에 넣어서 해당 데이터를 리스트의 형태로 변환합니다.
//    //8. All(조건문) : 배열 또는 컬렉션에서 모든 조건을 만족하면 true
//    //10. Any(조건문) : 배열 또는 컬렉션에서 하나라도 조건을 만족한다면 true
//    //11. Take(숫자) : Take 안에 넣은 숫자만큼의 데이터를 순서대로 가져옵니다. 
//    //12. Skip(숫자) : Skip 안에 넣은 숫자만큼 데이터를 순서대로 제외하고 남은 컬렉션을 반환합니다.
//    //13. Distinct() : 컬렉션 내에서 중복적인 요소를 제거합니다.
//    //14. OrderBy(조건) :   오름차순 정렬
//    //15. OrderByDesending(조건) : 내림차순 정렬

//    public class Profile //이름과 키를 가지고 있는 프로필
//    {
//        public string Name { get; set; }
//        public int Height { get; set; }
//    }

//    internal class Class54
//    {
//        static void Main(string[] args)
//        {
//            //(1) 배열
//            Profile[] profiles = 
//            { 
//                new Profile() {Name = "A", Height = 181 },
//                new Profile() {Name = "B", Height = 154 },
//                new Profile() {Name = "C", Height = 171 },
//                new Profile() {Name = "D", Height = 169 },
//                new Profile() {Name = "E", Height = 186 }                   
//            };
//            //(2) 컬렉션(리스트)
//            List<int> number_list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
//            //(2-1) 위의 리스트의 최대 값을 구합시다.
//            //일반적인 방법으로 최대 값 구하기
//            int max = number_list[0];//첫번째 값을 최대 값으로 지정(아래의 반복문을 통해 바꿔나가기)
//            foreach (int number in number_list)
//            {
//                if(max < number)
//                    max = number;
//            }
//            Console.WriteLine(max);
//            //(2-2) 링큐 메소드를 이용해 풀이
//            max = number_list.Max();
//            Console.WriteLine(max);
//            int min = number_list.Min();
//            int count = number_list.Count();
//            double average = number_list.Average(); 
//            Console.WriteLine(min);
//            Console.WriteLine(count);
//            Console.WriteLine(average);

//            //(1-1) 배열에서 특정 데이터 뽑아내기
//            //데이터 내부에 클래스처럼 여러 개의 데이터를 묶어서 표현하는 데이터를 대상으로는 조건을 통해
//            //뽑아낼 값을 처리합니다.

//            //프로필 중에서 키가 170 이하인 데이터만 저장 후 리스트로 변환
//            var new_profiles = profiles.Where(profile => profile.Height < 170).ToList();

//            foreach(var profile in new_profiles)
//            {
//                Console.WriteLine($"이름 : {profile.Name} 키 : {profile.Height}");
//            }

//            //프로필 중에서 키는 170 이상이고, 순서는 내림 차순으로 정렬하고 리스트로 변환
//            var descending_profiles =  profiles.Where(profile => profile.Height >= 170)
//                                                .OrderByDescending(profile => profile.Height)
//                                                .ToList();


//            foreach (var profile in descending_profiles)
//            {
//                Console.WriteLine($"이름 : {profile.Name} 키 : {profile.Height}");
//            }
//        }
//    }
//}
