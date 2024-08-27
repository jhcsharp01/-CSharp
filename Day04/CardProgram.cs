using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Shape
{
    Clover, Spade, Diamond, Heart
}
public class Card
{
    public Shape shape;
    public int number; //A 2 3 4 5 6 7 8 9 10 J Q K

    public Card(Shape shape, int number)
    {
        this.shape = shape;
        this.number = number;
    }
    public override string? ToString()
    {
        string result = "";

        if (number == 1)
            result = "A";
        else if (number == 11)
            result = "J";
        else if (number == 12)
            result = "Q";
        else if (number == 13)
            result = "K";
        else
            result = $"{number}";
        return $"{shape} {result} 카드";
    }
}
namespace ConsoleApp1.Day04
{
    internal class CardProgram
    {
        //static void draw(List<Card> hand)
        //{
        //    Random random = new Random(); //랜덤 설정
        //    Console.WriteLine("카드를 뽑겠습니다."); //안내문
        //    Card c = new Card((Shape)random.Next(0,4), random.Next(1,14));
        //    //모양 0 ~ 3 사이 중 하나 선택
        //    //숫자 1 ~ 13 사이 중 하나 선택
        //    hand.Add(c);
        //    //데이터 추가
        //}
        //static void ViewHands(List<Card> hand)
        //{
        //    foreach (Card c in hand)
        //    {
        //        Console.WriteLine(c.ToString());
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    #region sample
        //    //Card c = new Card(Shape.Heart, 1);
        //    //Console.WriteLine(c.ToString());
        //    //List<Card> hands = new List<Card>();
        //    ////ands.Add(c);
        //    ////hands.Add(c);
        //    //for(int i = 0; i < 5; i++)
        //    //{
        //    //    draw(hands);
        //    //}
        //    //ViewHands(hands);

        //    //Console.WriteLine("=현재 가지고 잇는 패 =");
        //    //int hand_score = 0;
        //    //foreach (Card card in hands)
        //    //{
        //    //    Console.WriteLine(card.ToString());
        //    //    hand_score += card.number;
        //    //}
        //    //Console.WriteLine($"패 점수 : {hand_score}");
        //    #endregion


        //}
    }
}
