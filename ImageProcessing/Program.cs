﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace ImageProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Bitmap.FromFile(@"F:\Downloads\WhatsApp Image 2017-11-27 at 21.23.15.jpeg");
            WriteLine(a.Height);
            WriteLine(a.Width);
            WriteLine(a.HorizontalResolution);
            WriteLine(a.VerticalResolution);
            var b = new Bitmap(a);
            WriteLine(b.Height);
            WriteLine(b.Width);
            WriteLine(b.HorizontalResolution);
            WriteLine(b.VerticalResolution);

            var H = b.Height;
            var W = b.Width;

            var list = new List<int>();
            for (int i = 0; i < W; i += 3)
                list.Add(i);

            var pixelList = new List<Pixel>();
            for (int m = 0; m < list.Count; m++)
                for (int n = 0; n < list.Count; n++)
                    pixelList.Add(new Pixel { X = list[m], Y = list[n] });

            pixelList.ForEach(p =>
            {
                WriteLine($"{DateTime.Now} - Setting X:{p.X} & Y:{p.Y}");
                b.SetPixel(p.X, p.Y, Color.Black);
            });
        }
    }

    class Pixel
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}