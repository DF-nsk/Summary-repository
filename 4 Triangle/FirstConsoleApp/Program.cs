using System;

using Microsoft.SmallBasic.Library;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.Show();
            int x = 100, y = 100;
            var Rnd = new Random();
            for (int i = 0; i < 100000; i++)
            {
                GraphicsWindow.SetPixel(x, y, "Black");
                var r = Rnd.Next(1, 30);
                if (r < 10) Move(ref x, ref y, 100, 500);
                else if (r < 20) Move(ref x, ref y, 600, 500);
                else Move(ref x, ref y, 350, 100);
            }
        }

        static void Move(ref int x, ref int y, int nx, int ny)
        {
            x = (x + nx) / 2;
            y = (y + ny) / 2;
        }

    }
}
