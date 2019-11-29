using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Pattern_Strategy
{
    public abstract class LineEnd
    {

        int x, y;

        public LineEnd()
        {
            x = Program.r.Next(-10, 11);
            Console.Write("...");
            y = Program.r.Next(-10, 11);
        }
        public virtual string paint()
        {
            return "x=" + x + ",\ty=" + y;
        }
    }
}
