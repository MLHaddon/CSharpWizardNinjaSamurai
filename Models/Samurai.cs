using System;

namespace HumanProject.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name, 3,3,3,200) {
            name = Name;
        }

        public Samurai(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)  {
            name = Name;
            str = Strength;
            intel = Intelligence;
            dex = Dexterity;
            hp = 200;
        }

        public override int Attack(Human target) {
            int hp = base.Attack(target);
            if (hp < 50) {
                target.takeDmg(hp);
                Console.WriteLine($"{target.Name}'s Health Dropped to Zero\n Current Target HP {target.health}, Current HP {Health}.");
            }
            return target.health;
        }

        public int Meditate() {
            Health = 200;
            Console.WriteLine($"{Name} finished meditating, and is back to {Health} health.");
            return Health;
        }
    }
}