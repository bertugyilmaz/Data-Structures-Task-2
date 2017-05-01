﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurgutluBank
{
    interface IQueue
    {
        void Insert(object o);
        object Remove();
        object Peek();
        Boolean isEmpty();
    }
}