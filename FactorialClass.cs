﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20Day15
{
    public class FactorialClass
    {
        public int factoral(int n)
        {
            if (n == 1 || n==0)
            {
                return 1;
            }
            return n * factoral(n - 1);
        }
    }
}
