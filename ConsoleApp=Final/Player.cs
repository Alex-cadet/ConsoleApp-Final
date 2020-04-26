using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Player : POM  //Игрок
    {
        public Player(string st, string n, int a, int N) : base(st, n, a)
        {
            Num = N;
        }
        protected int Num;       //номер игрока
        int Salary;    //зарплата
        int Contract;  //срок контракта
        int Games;     //количество проведённых игр
        int Reserve;   //число игр в запасе
        void Contribution()
        {
            int Act = ((Games - Reserve) / Salary) * 100;
            Console.WriteLine("Вклад в игру:{act} % ", Act);
        }
        public override void About()
        {
            Console.WriteLine("Игрок {0} под номером {1} - капитан команды", Name, Num);
        }
    }
}
