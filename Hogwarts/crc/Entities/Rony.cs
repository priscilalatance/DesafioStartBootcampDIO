namespace Hogwarts.crc.Entities
{
    public class Rony : Hero
    {       
        public Rony(string Name, string House, string HeroType) : base(Name, House, HeroType)
        {
            this.Name = Name;
            this.House = House;
            this.HeroType = HeroType;

        }        
        public override string Attack()
        {
            return $"{this.Name} Resolveu os confritos de forma eficaz.";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return  $"{this.Name} Resolveu de forma efetiva os confritos e recebeu bonus de {Bonus}.";
            }
            else
            {
                return  $"{this.Name} Resolveu de forma eficiente os confritos e recebeu bonus de {Bonus}.";
            }
        }
    }
}