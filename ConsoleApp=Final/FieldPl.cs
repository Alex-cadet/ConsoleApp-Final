using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class FieldPl : Player  //полевой Игрок
    {
        public FieldPl(string st, string n, int a, int N, string Amp) : base(st, n, a, N)
        {
            Amplua = Amp;
        }

        public string Amplua; //амплуа: нападающий, полузащитник, защитник
        public int goals;  //количество голов
        public int pass;   //количество пассов
        public int golpas; //количество голевых передач
        public override void About()
        {
            int com = goals + golpas;
            Console.WriteLine("{0} {1} под {2} номером ", Amplua, Name, Num);
            Console.WriteLine("забил - {0} голов; отдал {1} пасов, из них - {2} голевых", goals, pass, golpas);
            Console.WriteLine("По системе гол плюс пас: {0} очков", com);
        }
    }
}
