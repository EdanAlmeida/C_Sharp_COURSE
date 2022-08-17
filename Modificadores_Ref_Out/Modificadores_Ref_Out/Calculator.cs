using System;
using System.Collections.Generic;
using System.Text;

namespace Modificadores_Ref_Out
{
    class Calculator
    {
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}

/*
            //Modificador 'ref'
            public static void Triple(ref int x)
            {
                x = x * 3;
            }
 */

