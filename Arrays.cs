using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCource.OOPBasics2
{
    public static class Arrays
    {
        public static void Run()
        {
            System.ICloneable[] cloneables = { "", new int[] { 1, 2, 3 } };
            foreach (var cloneable in cloneables)
                cloneable.Clone();
        }
    }
}
