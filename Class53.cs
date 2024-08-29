using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //delegate 없이 이벤트 사용하기
    public class MyButton
    {
        public string Text;
        public event EventHandler Click;
        //이벤트에 대한 응답을 제공하는 메소드를 식별하는 대리자

        public void OnMyButtonDown()
        {
            if (Click != null)
            {
                //이벤트 핸들러들을 호출합니다.
                //여기서의 this는 핸들러에 등록되어 있는 것들을 의미합니다.
                //EventArgs.Empty는 해당 기능에 따로 전달할 매개변수가 없음.
                Click(this, EventArgs.Empty);
            }
        }
    }
    internal class Class53
    {
        static void Main(string[] args)
        {
            MyButton button = new MyButton();
            button.Click += new EventHandler(btn_click);
            button.Text = "Run";
            button.OnMyButtonDown();
        }

        private static void btn_click(object? sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString(), e);
        }
    }
}
