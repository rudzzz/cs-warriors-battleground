using System;

namespace WarriorFight{
    class Program{
        static void Main(string[] args){
            Warrior sam = new Warrior("Sam", 100, 26, 10);
            MagicWarrior carl = new MagicWarrior("Carl", 75, 20, 10, 50);

            Battle.StartFight(sam, carl);
        }
    }
}
