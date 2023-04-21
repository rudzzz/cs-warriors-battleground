using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight {
    internal class Warrior {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMaximum { get; set; }
        public double BlockMaximum { get; set; }

        Random randomNumber = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attackMaximum = 0, double blockMaximum = 0) { 
            this.Name = name;
            this.Health = health;
            this.AttackMaximum = attackMaximum;
            this.BlockMaximum = blockMaximum;
        }

        public double Attack(){
            return randomNumber.Next(1, (int)AttackMaximum);
        }
        public virtual double Block(){
            return randomNumber.Next(1, (int)BlockMaximum);
        }
    }
}
