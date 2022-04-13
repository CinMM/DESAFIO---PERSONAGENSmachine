namespace DESAFIO___PERSONAGENS.SRC.ENTITIES
{
    public class Wizard : Hero
    {          
        public Wizard(string Name, int Level, string Herotype)
        : base (Name, Level, Herotype) 
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;            
        }
        
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Herotype;        
        }
        
        public override string Attack ()
        {
            return this.Name + " lançou magia. ";
            
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia com bônus de ataque de " + Bonus;
            }else
                return this.Name + " lançou uma magia, com força fraca, com bônus de " + Bonus;
            
        }
    }
}
