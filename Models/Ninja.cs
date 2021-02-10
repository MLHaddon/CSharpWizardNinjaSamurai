using System;

namespace HumanProject.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100) {
            name = Name;
        }

        public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, 175, hp) {
            name = Name;
            str = Strength;
            intel = Intelligence;
            hp = Health;
        }

        public override int Attack(Human target) {
            // Base Damage
            int dmg = Dexterity * 5;

            // Damage Modifier
            Random rand = new Random();
            if (rand.Next(1,5) == 1) {
                dmg += 10;
            }

            target.takeDmg(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!\n Current Target HP {target.health}, Current HP {Health}.");
            return target.health;
        }

        public int Steal(Human target) {
            target.takeDmg(5);
            Health += 5;
            Console.WriteLine($"{Name} Stole 5 health from {target.Name}!");
            return Health;
        }
    }
}