﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_Strategy
{
    public class LineRomb : LineEnd
    {
        public LineRomb() : base()
        {
        }
        public override string paint()
        {
            return base.paint() + ",\tRomb\n";
        }
    }
}

