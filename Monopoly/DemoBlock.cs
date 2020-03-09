using System;
using System.Activities;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monopoly
{
    class DemoBlock
    {
        public DemoBlock(Point p)
        {
            Location = p;
        }

        public Point Location { get; set; }

        public int StopAction(int score)
        {
            return score + 10;
        }
    }
}
