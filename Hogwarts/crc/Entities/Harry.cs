namespace Hogwarts.crc.Entities
{
    public class Harry : Hero
    {        
        public Harry(string Name, string House, string HeroType) : base(Name, House, HeroType)
        {
            this.Name = Name;
            this.House = House;
            this.HeroType = HeroType;

        }
    }
}