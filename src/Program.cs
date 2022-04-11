using System;
using abstraindo_um_rpg_poo.src.Entities;

namespace abstraindo_um_rpg_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "Knigth");

            Console.WriteLine(hero);
        }
    }
}
