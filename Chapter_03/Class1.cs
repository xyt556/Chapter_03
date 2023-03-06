using System;

namespace Chapter_03
{
    public class Class1
    {
        public int i = 0;
        public Class1()
        {
            i = 10;
        }
        private class AA
        {
            public int a = 1;
        }
        internal class BB
        {
            internal int b = 2;
            AA aa = new AA();
        }

    }
}