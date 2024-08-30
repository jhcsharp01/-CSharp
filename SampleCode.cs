//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class IDCheck
//    {
//        public Dictionary<string, string> haveId;

//        public IDCheck(Dictionary<string, string> haveId)
//        {
//            this.haveId = haveId;
//        }
//    }
//    class Car
//    {
//        private string id;
//        private int time;
//        private bool park;

//        public Car(string id, int time)
//        {
//            this.id = id;
//            this.time = time;
//        }
//        public bool IDComp(Car car, IDCheck CheckList)
//        {
//            if (CheckList.haveId.ContainsKey(car.id))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        public void Check(Car car, IDCheck CheckList)
//        {
//            if (IDComp(car, CheckList))
//            {
//                Console.WriteLine($"{car.id}차량, 주차권 소지중입니다\n유효기간 :{CheckList.haveId[car.id]}");
//                Print(car);
//                GetOut(car);
//            }
//            else
//            {
//                Console.WriteLine($"{car.id}, 미등록 차량입니다\n주차 시간 : {car.time}시간");
//                GetOut(car);
//            }
//        }
//        public void Print(Car car)
//        {
//            Console.WriteLine($"행복병원 주차권 \n차량 : {car.id}\n주차 시간 : {car.time}시간");
//        }
//        public void GetOut(Car car)
//        {
//            Console.WriteLine($"차단기가 열립니다. 안녕히가세요.");
//        }
//    }
//    internal class SampleCode
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, string> ParkingList = new Dictionary<string, string>();
//            ParkingList.Add("11 가 1111", "2024-10-14");
//            IDCheck CheckList = new IDCheck(ParkingList);
//            Car car = new Car("11 가 1111", 1);
//            car.Check(car, CheckList);
//        }
//    }
//    //class Car
//    //{
//    //    public int car_number;
//    //    public bool haveTicket;

//    //    public Car(int num, bool ticket)
//    //    {
//    //        this.car_number = num;
//    //        this.haveTicket = ticket;
//    //    }
//    //}
//    //internal class SampleCode
//    //{
//    //    static void CheckTicket(Car car)
//    //    {
//    //        Console.WriteLine("--------차량이 진입합니다.--------");
//    //        if (car.haveTicket == true)
//    //        {
//    //            Console.WriteLine($"차량번호[{car.car_number}]주차권을 보유한 차량입니다.");
//    //            Open();
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("주차권을 보유하지 않은 차량입니다.");
//    //            PrintTicket();
//    //            Open();
//    //        }
//    //    }

//    //    public static void PrintTicket()
//    //    {
//    //        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " 주차권이 출력되었습니다.");

//    //    }

//    //    public static void Open()
//    //    {
//    //        Console.WriteLine("차단기가 열렸습니다.");
//    //    }


//    //    static void Main(string[] args)
//    //    {
//    //        Car car = new Car(1234, true);
//    //        Car car2 = new Car(1391, false);
//    //        Car car3 = new Car(2887, true);

//    //        CheckTicket(car);
//    //        CheckTicket(car2);
//    //        CheckTicket(car3);

//    //    }
//    //}
//}


//        //internal class SampleCode
//        //{
//        //    static void Main(string[] args)
//        //    {
//        //        //자동차가 진입하면 시간을 기록하고, 주차권을 가진 자동차인지 확인합니다.

////        //if(주차권을 가진 차량이라면)
////        //        차단기를 오픈해주세요.(차단기는 기능으로 구성)
////        //else
////        //    시간이 찍힌 주차증을 출력합니다.(주차증 출력은 기능으로 구성)
////        //    차단기를 오픈해주세요.(차단기는 기능으로 구성)
////        Enter("ㅅㄴㅌ0000");
////        Enter("ㅁㄴ1111");

////    }

////    //주차권 확인()
////    //{
////    //    등록된 차량인지 확인
////    //    if(차량이라면)
////    //        차량 확인 결과 반환
////    //    else
////    //        비등록차량 확인 결과 반환
////    //}
////    public static void Enter(string car)
////    {
////        List<string> cars = new List<string>
////        {"ㅅㄴㅌ0000", "ㄹㅂㄹㄱㄴ9999", "ㅍㄹㅅ8888", "ㅆㄹㅌ7777", "ㄹㄴ6666"  };
////        foreach (string ca in cars)
////        {
////            if (car == ca)
////            {
////                Console.WriteLine($"{ca}는 등록된 차량입니다.\n시간을 출력합니다.");
////                Print();
////                Open();
////                return;
////            }
////        }

////        Console.WriteLine($"{car} 확인 결과");
////        Console.WriteLine("등록되지 않은 차량입니다.");


////    }

////    //주차증 출력()
////    //{
////    //    시간이 찍힌 주차권을 출력
////    //}
////    public static void Print()
////    {
////        Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
////    }

////    //차단기 오픈()
////    //{
////    //    차단기를 열어주세요.
////    //}
////    public static void Open()
////    {
////        Console.WriteLine("차단기가 열립니다.");
////    }
////}


////class ParkingTicket
////{
////    public string time;

////    public ParkingTicket(string time)
////    {
////        this.time = time;
////    }
////}
////class Car
////{
////    public Car()
////    {
////        ticket = null;
////    }
////    public ParkingTicket? ticket;

////    public void EnterParkinglot()
////    {
////        Console.WriteLine("주차장에 진입합니다.");
////        ParkingBreaker.OpenParkingBreaker(this);
////        ParkingBreaker.CloseParkingBreaker();
////    }
////    public void LeaveParkinglot()
////    {
////        Console.WriteLine("주차장을 떠납니다.");
////        ParkingBreaker.OpenParkingBreaker(this);
////        ParkingBreaker.CloseParkingBreaker();
////    }
////}

////class ParkingBreaker
////{
////    public static void OpenParkingBreaker(Car car)
////    {
////        if (car.ticket == null)
////        {
////            Console.WriteLine("주차권을 확인할 수 없습니다.");
////            PrintParkingTicket(car);
////            return;
////        }

////        Console.WriteLine("차단기를 열었습니다.");
////    }
////    public static void CloseParkingBreaker()
////    {
////        Console.WriteLine("차단기를 닫았습니다.");
////    }

////    public static void PrintParkingTicket(Car car)
////    {
////        Console.WriteLine("주차권을 발행합니다.");
////        car.ticket = new ParkingTicket(DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss"));
////    }
////}
////internal class SampleCode
////{
////    static void Main(string[] args)
////    {
////        Car car = new Car();
////        car.EnterParkinglot();
////        Console.WriteLine();
////        car.LeaveParkinglot();
////    }
////}




////internal class SampleCode
////{
////    static void Main(string[] args)
////    {
////        string now = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
////        Console.WriteLine(now);

////        //자동차가 진입하면 시간을 기록하고
////        //주차권을 가진 자동차인지 확인합니다.

////        //if (주차권을 가진 차량이라면)
////        //        차단기를 오픈해주세요. (차단기는 기능으로 구성)
////        //else
////        //    시간이 찍힌 주차증을 출력합니다.(주차층 출력은 기능으로 구성)
////        //    차단기를 오픈해주세요.(차단기는 기능으로 구성)
////    }

////    //주차권확인()
////    //{
////    //    등록된 차량인지 확인
////    //    if (등록된 차량이라면)
////    //        차량 확인 결과 반환
////    //    else
////    //        비등록차량 확인 결과 반환
////    //}

////    //주차증 출력()
////    //{
////    //    시간이 찍힌 주차권을 출력
////    //}

////    //차단기 오픈()
////    //{
////    //        차단기를 열여주세요.
////    //}

////}
//// }
