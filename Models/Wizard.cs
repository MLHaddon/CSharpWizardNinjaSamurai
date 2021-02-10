using System;

namespace HumanProject.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name,3,25,3,50) {
            name = Name;
        }

        public Wizard(string name, int strength, int dex) : base(name, strength, 25, dex, 50) {
            name = Name;
            strength = Strength;
            dex = Dexterity;
        }
        
        public override int Attack(Human target) {
        // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. 
        // The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). 
        // This method should return the remaining health of the target object.
            int dmg = Intelligence * 5;
            target.takeDmg(dmg);
            Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!\n Current Target HP {target.health}, Current HP {Health}.");
            return target.health;
        }

        public int Heal(Human target) {
            int amount = Intelligence * 10;
            target.getHealed(amount);
            Console.WriteLine($"{Name} healed {target.Name} for {amount}!\n Current Target HP {target.health}, Current HP {Health}.");
            return target.health;
        }
    }
}