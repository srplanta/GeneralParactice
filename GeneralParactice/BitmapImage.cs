using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralParactice
{
    //BitmapImage provides implementation of IAdvancedDraw & IDrawable
    //IAdvancedDraw is inherited from IDrawable
    public class BitmapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing from Draw()...");
        }

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing from DrawInBoundingBox(int top, int left, int bottom, int right)...");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing from DrawUpsideDown()...");
        }
    }
}
