using System;

namespace HumanProject.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int Health;
        public int health {
            get {
                return Health;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name) {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intel, int dex, int hp) {
            Name = name;
            Strength = strength;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
        }
        // Build Attack method
        public virtual int Attack(Human target) {
            int dmg = Strength * 3;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!\n Current Target HP {target.health}, Current HP {Health}.");
            return target.Health;
        }
        public int takeDmg(int dmg) {
            Health -= dmg;
            return Health;
        }

        public int getHealed(int amount) {
            Health += amount;
            return Health;
        }
    }
}