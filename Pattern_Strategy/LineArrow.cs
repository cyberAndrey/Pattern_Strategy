using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy
{
    public class LineArrow : LineEnd
    {
        public LineArrow() : base()
        {
        }
        public override string paint()
        {
            return base.paint() + ",\tArrow\n";
        }
    }
}
