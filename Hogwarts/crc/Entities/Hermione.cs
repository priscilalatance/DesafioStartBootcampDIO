namespace Hogwarts.crc.Entities
{
    public class Hermione : Hero
    {
        public Hermione(string Name, string House, string HeroType) : base(Name, House, HeroType)
        {
            this.Name = Name;
            this.House = House;
            this.HeroType = HeroType;

        }
        public override string Attack()
        {
            return $"{this.Name} Atacou com Inteligência de forma eficaz os seus oponentes.";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return  $"{this.Name} Atacou com Inteligência os seus oponentes de forma efetiva e recebeu bonus de {Bonus}.";
            }
            else
            {
                return  $"{this.Name} Atacou com Inteligência os seus oponentes de forma eficiente e recebeu bonus de {Bonus}.";
            }
        }
    }
}