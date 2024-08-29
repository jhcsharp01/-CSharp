using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //delegate를 이용해서 다음 상황을 코드로 연출합니다.
    //체력과 돈과 이름 공격력을 가지는 몬스터 클래스
    //체력과 돈과 이름 공격력을 가지는 플레이어 클래스
    //몬스터가 공격을 당할 경우 데미지 받는 함수가 호출됩니다.
    //공격을 받은 후에는 몬스터가 공격을 진행합니다.
    //몬스터가 쓰러졌을 때, 돈을 획득하는 기능을 구현합니다.
    //기능에 대한 부분은 콘솔 출력으로 구현합니다.

    public abstract class Unit
    {
        public int hp;
        public int money;
        public string? name;
        public int atk;

        protected Unit(int hp, int money, string? name, int atk)
        {
            this.hp = hp;
            this.money = money;
            this.name = name;
            this.atk = atk;
        }

        public abstract void Attack(Monster m, Player p);
        public abstract void GetDamage(Monster m, Player p);
        public abstract void DropMoney(Monster m, Player p);
    }
    delegate void Battle(Monster m, Player p); 
    public class Monster : Unit
    {
        public Monster(int hp, int money, string? name, int atk) : base(hp, money, name, atk)
        {
        }

        public override void Attack(Monster m, Player p)
        {
            Console.WriteLine($"{p.name}에게 공격을 진행합니다!");
        }
        public override void DropMoney(Monster m, Player p)
        {
            p.money += money;
            Console.WriteLine($"{p.name}은 {money}를 획득했습니다! 보유 금액 : {p.money}");


        }
        public override void GetDamage(Monster m, Player p)
        {
            Console.WriteLine($"{p.name}에게 데미지를 받았습니다!");
            hp -= p.atk;
        }
    }
    public class Player : Unit
    {
        public Player(int hp, int money, string? name, int atk) : base(hp, money, name, atk)
        {
        }

        public override void Attack(Monster m, Player p)
        {
            Console.WriteLine($"{m.name}에게 공격을 진행합니다!");
        }
        public override void DropMoney(Monster m, Player p)
        {
            Console.WriteLine($"{name}은 가진 돈의 절반을 잃었습니다.");
            money /= 2;
            Console.WriteLine($"남은 금액 {money}");
        }
        public override void GetDamage(Monster m, Player p)
        {
            Console.WriteLine($"{m.name}에게 데미지를 받았습니다!");
            hp -= m.atk;

        }
    }

    internal class Class51
    {
        static void Main(string[] args)
        {
            Monster monster = new Monster(50, 50, "몬스터A", 1);
            Player player = new Player(50, 500, "플레이어", 10);
            Battle battle = player.Attack;
            battle += monster.GetDamage;
            battle += monster.Attack;
            battle += monster.DropMoney;

            battle(monster, player);
        }
    }
}
