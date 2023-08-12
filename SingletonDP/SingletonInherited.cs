using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDP
{
    public class SingletonInherited
    {
        public static int Numbers { get; set; }


        public void GetNumbers()
        {

        }
    }

    public class StaticMemberAccessor
    {
        public StaticMemberAccessor()
        {
            SingletonInherited.Numbers =6;
            SingletonInherited k = new SingletonInherited();
            k.GetNumbers();
        }
    }
}
