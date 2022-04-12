using System;
using abstraindo_um_rpg_poo.src.Entities;

namespace abstraindo_um_rpg_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knigth");
            Wizard Mago = new Wizard("Mestre das sombras", 35, "Devil");

            Console.WriteLine(Mago.Attack(2));
            Console.WriteLine(Mago.Attack(8));
        }
    }
}
