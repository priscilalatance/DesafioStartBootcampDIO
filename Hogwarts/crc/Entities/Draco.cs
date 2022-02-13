namespace Hogwarts.crc.Entities
{
    public class Draco : Hero
    {
        public Draco(string Name, string House, string HeroType) : base(Name, House, HeroType)
        {
            this.Name = Name;
            this.House = House;
            this.HeroType = HeroType;

        }        
        public override string Attack()
        {
            return $"{this.Name} Influenciou os seus oponentes de forma eficaz.";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return  $"{this.Name} Influenciou os seus oponentes de forma efetiva e recebeu bonus de {Bonus}.";
            }
            else
            {
                return  $"{this.Name} Influenciou os seus oponentes de forma eficiente e recebeu bonus de {Bonus}.";
            }
        }
   }    
}