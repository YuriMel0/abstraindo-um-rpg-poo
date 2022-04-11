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
    }
}