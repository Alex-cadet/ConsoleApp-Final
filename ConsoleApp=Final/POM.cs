using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public abstract class POM // Participant Of the Match: участник футбольного матча
    {
        public string Status { get; set; }  //статус: судит, играет, тренирует
        public string Name { get; set; } //
        public int Age { get; set; }
        public POM(string st, string n, int a)
        {
            Status = st;
            Name = n;
            Age = a;
        }
        public abstract void About();
    }
}
