using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luwei_2
{
    class banknote
    {
        private int _remainder;
        public banknote(int total)
        {
            _remainder = total;
            m1000 = GetNumber(1000);
            m500 = GetNumber(500);
            m100 = GetNumber(100);
            m50 = GetNumber(50);
            m10 = GetNumber(10);
            m5 = GetNumber(5);
            m1 = GetNumber(1);
        }

        public int m1000 { get; private set; }
        public int m500 { get; private set; }
        public int m100 { get; private set; }
        public int m50 { get; private set; }
        public int m10 { get; private set; }
        public int m5 { get; private set; }
        public int m1 { get; private set; }

        private int GetNumber(int money)
        {
            var resule = _remainder / money;
            _remainder = _remainder % money;
            return resule;
        }
    }
}
