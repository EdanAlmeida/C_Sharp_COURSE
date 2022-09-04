namespace Composition1.Entities
{
    class Department
    {
        public string Name { get; set; }

        //construtor padrão
        public Department()
        {
        }
        
        //construtor com o parâmetro
        public Department(string name)
        {
            Name = name;
        }
    }
}
