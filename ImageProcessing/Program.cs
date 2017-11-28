using System;
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
        }
    }
}
