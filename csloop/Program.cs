using System;
using System.Threading;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복됨");
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            */
            /*
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);
                x++;
            }
            */
            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽로 이동");
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }
        }
    }
}
