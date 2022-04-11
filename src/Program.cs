using System;
using abstraindo_um_rpg_poo.src.Entities;

namespace abstraindo_um_rpg_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knigth");
            Wizard oponente = new Wizard("Mestre das sombras", 35, "Devil");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(oponente.Attack());
        }
    }
}
