using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight {
    class Battle {
        public static void StartFight(Warrior warrior1, Warrior warrior2){
            while(true){
                if(AttackResult(warrior1, warrior2) == "Game Over!"){
                    Console.WriteLine("Game Over");
                    break;
                }
                if(AttackResult(warrior2, warrior1) == "Game Over!"){
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string AttackResult(Warrior warrior1, Warrior warrior2){
            double warrior1AttackAmount = warrior1.Attack();
            double warrior2BlockAmount = warrior2.Block();

            double damageToWarriorB = warrior1AttackAmount - warrior2BlockAmount;

            if(damageToWarriorB > 0){
                warrior2.Health -= damageToWarriorB;
            } else {
                damageToWarriorB = 0;
            }

            Console.WriteLine($"{warrior1.Name} Attacks {warrior2.Name} and Deals {damageToWarriorB} Damage!");
            Console.WriteLine($"{warrior2.Name} Has {warrior2.Health} Health\n");

            if(warrior2.Health <= 0){
                Console.WriteLine($"{warrior2.Name} Has Died! {warrior1.Name} Wins!\n");
                return "Game Over!";
            } else{
                return "Fight Again!";
            }
        }
    }
}
