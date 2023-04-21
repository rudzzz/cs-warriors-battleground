using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class MagicWarrior : Warrior {
        int teleportChance = 0;
        CanTeleport teleportType = new CanTeleport();

        public MagicWarrior(string name = "Magic Warrior",
        double health = 0,
        double attackMaximum = 0,
        double blockMaximum = 0,
        int teleportChance = 0) : base(name, health, attackMaximum, blockMaximum) { 
            this.teleportChance = teleportChance;
        }

        public override double Block(){
            Random randomNumber = new Random();
            int randomDodge = randomNumber.Next(1, 100);

            if(randomDodge < this.teleportChance){
                Console.WriteLine($"{Name} {teleportType.teleport()}");
                return 10000;
            } else {
                return base.Block();
            }
        }
    }
}
