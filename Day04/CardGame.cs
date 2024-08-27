//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Player
//    {
//        public int money = 100; //시작 베팅금
//        public List<Card> hands = new List<Card>(); //패
//        public bool isdraw = true; //뽑기 여부
//        public int check; //체크

//        public int score_count()
//        {
//            int result = 0;
//            foreach (Card card in hands)
//            {
//                result += card.number;
//            }
//            return result;
//        }
//        public void set_score(int score)
//        {
//            check = score;
//        }
//    }

//   //Card c = new Card((Shape)random.Next(0, 4), random.Next(1, 14));
//    internal class CardGame
//    {
//        static void ViewHands(List<Card> hand)
//        {
//            foreach (Card c in hand)
//            {
//                Console.WriteLine(c.ToString());
//            }
//        }

//        static void DeckSetting(List<Card> deck)
//        {
//            //deck.Clear();
//            for (int i = 0; i < 4; i++) //문양의 개수
//            {
//                for (int j = 0; j < 13; j++) //카드의 개수
//                {
//                    Card card = new Card((Shape)i, j + 1);
//                    deck.Add(card);
//                }
//            }
//        }

//        static void Draw(List<Card> deck, Player player)
//        {
//            Random random = new Random();
//            Card c = new Card((Shape)random.Next(0, 4), random.Next(1, 14));

//            foreach (Card card in deck)
//            {
//                if (c.shape == card.shape && c.number == card.number)
//                {
//                    player.hands.Add(card);
//                    deck.Remove(card);
//                    break;
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            Player player = new Player();        
//            Player other = new Player();

//            List<Card> Decks = new List<Card>();
//            DeckSetting(Decks);

//            Draw(Decks, player);
//            Draw(Decks, other);
//            ViewHands(player.hands);
//            ViewHands(other.hands);
//            ViewHands(Decks);

//            int betting = 0;

//            Console.Write("게임 시작 전 배팅을 진행해주세요.");
//            int price = int.Parse(Console.ReadLine());
//            player.money -= price;
//            betting += price;

//            int turn = 0; //0은 플레이어 턴 , 1은 상대방 턴

//            //while(true)
//            //{
//            //    Console.WriteLine($"베팅 금액  : {betting}");
//            //    if(turn == 0 && player.isdraw == true)
//            //    {
//            //        Console.WriteLine("플레이어의 턴입니다. 뽑기를 진행하시겠습니까? Y / N");
//            //        string select = Console.ReadLine();
//            //        if(select == "Y")
//            //        {
//            //            Console.WriteLine("카드를 뽑았습니다!");
//            //            Draw(Decks, player);
//            //            Console.Write("추가 베팅하시겟습니까? Y /N ");
//            //            select = Console.ReadLine();
//            //            if (select == "Y")
//            //            {
//            //                Console.Write("베팅할 금액을 입력해주세요");
//            //                price = int.Parse(Console.ReadLine());
//            //                if(player.money < price)
//            //                {
//            //                    Console.WriteLine("베팅 금액이 부족합니다.");
//            //                }
//            //                else
//            //                {
//            //                    player.money -= price;
//            //                    betting += price;
//            //                }
//            //            }
//            //        }
//            //        else
//            //        {
//            //            Console.WriteLine("뽑기를 중단하셨습니다. 다음 턴부터 뽑기가 불가능합니다.");
//            //            player.isdraw = false;
//            //        }
//            //    }

//            //    turn = 1;


//            //    //상대방 턴(자동으로 설계)
//            //    if (turn == 1 && other.isdraw == true)
//            //    {
//            //        if(other.score_count() > 16)
//            //        {
//            //            Console.WriteLine("뽑기를 중단하셨습니다. 다음 턴부터 뽑기가 불가능합니다.");
//            //            other.isdraw = false;
//            //        }
//            //        else
//            //        {
//            //            Console.WriteLine("카드를 뽑았습니다!");
//            //            Draw(Decks, player);
//            //        }
//            //    }

//            //    turn = 0;


//            //}    



//        }
//    }
//}
