namespace abstraindo_um_rpg_poo.src.Entities
{
    public class Arus
    {
        public Arus(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return $@" Name: {this.Name} Level: {this.Level} Hero type: {this.HeroType}";            
        }
    }
}