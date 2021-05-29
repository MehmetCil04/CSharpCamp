using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Fırat");
            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(5);
        }
    }
}
