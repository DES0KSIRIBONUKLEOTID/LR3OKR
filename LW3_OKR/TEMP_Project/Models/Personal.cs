
namespace LW3_OKR.Models
{
    public class Personal
    {

        public string? Id { get; set; }

        public string SurName { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }
        public string Stat { get; set; }

        public string Image { get; set; }
        public Personal () 
        {
            SurName = "";
            Name = "";
            Position = "";  
            Stat = "";
        }
        public Personal (string surname, string name, string position, string stat)
        {
            SurName = surname;
            Name = name;
            Position = position;
            Stat = stat;
        }
    }
}

