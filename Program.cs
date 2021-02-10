using System;
using HumanProject.Models;

namespace HumanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Human dummy1 = new Human("dummy1");
            Human dummy2 = new Human("dummy2");
            Human dummy3 = new Human("dummy3");

            Wizard wizard = new Wizard("wizard");
            Ninja ninja = new Ninja("ninja");
            Samurai samurai = new Samurai("samurai");

            wizard.Attack(dummy1);
            ninja.Attack(dummy2);
            for (int i = 0; i < 6; i++) {
                samurai.Attack(dummy3);
            }

            wizard.Heal(dummy1);
            ninja.Steal(dummy2);
            ninja.Attack(samurai);
            samurai.Meditate();

        }
    }
}
