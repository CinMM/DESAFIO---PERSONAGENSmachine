namespace DESAFIO___PERSONAGENS.SRC.ENTITIES
{
    public class Knight : Hero
    {
        public Knight (string Name, int Level, string Herotype)
        : base (Name, Level, Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;            
        }

    }
}