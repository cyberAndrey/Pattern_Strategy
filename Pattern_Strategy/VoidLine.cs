using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy
{
    public class VoidLine : LineEnd
    {
        public VoidLine() : base()
        {
        }
        public override string paint()
        {
            return base.paint() + ",\tVoid\n";
        }
    }
}
