namespace abstraindo_um_rpg_poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Wizard()
        {
            
        }
        public override string Attack()
        {
           return $"{this.Name} Lançou uma pedra com dano de água";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return $"{this.Name} Lançou Magia super efetiva com bonus de {Bonus}";
            }
            else
            {
                return $"{this.Name} Lançou Magia fraca com bonus de {Bonus}";
            }
        }
    }
}