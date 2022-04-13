namespace DESAFIO___PERSONAGENS.SRC.ENTITIES
{
    public class BlackWizard : Hero
    {          
        public BlackWizard(string Name, int Level, string Herotype)
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
            return this.Name + " lançou raios. ";
        }
    }
}