using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class OutG : System.Attribute //класс атрибута
    {
        public int offG;
        public OutG() { }
        public OutG(int los)
        {
            offG = los;
        }
    }
}
