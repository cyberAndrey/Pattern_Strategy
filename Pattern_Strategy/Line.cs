using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy
{
    public class Line
    {
        LineEnd linestart, lineend;
   
        public Line(LineEnd start, LineEnd end)
        {
            linestart = start;
            lineend = end;
        }
        public void SetStartLine(LineEnd a)
        {
            linestart = a;
        }
        public void SetEndLine(LineEnd a)
        {
            lineend = a;
        }
        public string PrintLine()
        {
            return linestart.paint() + lineend.paint();
        }
    }
}
