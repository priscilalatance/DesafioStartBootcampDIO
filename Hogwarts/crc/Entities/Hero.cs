namespace Hogwarts.crc.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, string House, string HeroType) 
        {
            this.Name = Name;
            this.House = House;
            this.HeroType = HeroType;

        }

        public string Name { get; set; }

        public string House { get; set; }

        public string HeroType { get; set; }


        public override string ToString()
        {
            return $"{this.Name} {this.House} {this.HeroType}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} Atacou com a sua Elder Wand.";
        }


    }
}