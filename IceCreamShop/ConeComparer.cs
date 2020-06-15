﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            if (x.Cost - y.Cost == 0)
            {
                return 0;
            }
            else if (x.Cost > y.Cost)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
