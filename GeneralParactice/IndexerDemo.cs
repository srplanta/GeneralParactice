using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralParactice
{
    internal class IndexerDemo
    {
        int[] Age = new int[10];

        //in simple indexers are Get/Set properties for arrays/lists/collections
        public int this[int index]      //return type > int | must have on parameter > this[int index]
        {
            get
            {
                return Age[index];
            }
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Invalid value!");
                    }
                    else
                    {
                        Age[index] = value;
                    }
                }
                else
                {
                    Console.WriteLine("invalid index");
                }
            }
        }
    }
}
