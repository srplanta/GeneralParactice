using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralParactice
{
    //Explicitly implemented interface
    //inheriting 3 Interfaces with same name methods
    public class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //public void Draw()
        //{
        //    Console.WriteLine("Drawing Octagone, Same named method in IDrawToForm, IDrawToMemory, IDrawToPrinter");
        //}
        //####################################################################################

        void IDrawToForm.Draw()         //Explicitly implemented interface
        //no access modifier, explicitly implemented members are implicitly private
        {
            Console.WriteLine("Drawing to form!");
        }

        void IDrawToMemory.Draw()       //Explicitly implemented interface
        //no access modifier, explicitly implemented members are implicitly private
        {
            Console.WriteLine("Drawing to memory!");
        }

        void IDrawToPrinter.Draw()      //Explicitly implemented interface
        //no access modifier, explicitly implemented members are implicitly private
        {
            Console.WriteLine("Drawing to printer!");
        }
    }
}
