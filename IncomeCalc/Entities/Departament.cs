
namespace IncomeCalc.Entities
{
    class Departament
    {
        public string Name { get; set; }

        //COnstrutor padrão
        public Departament()
        {

        }

        //Construtor que recebe o nome
        public Departament(string name)
        {
            Name = name;
        }
    }
}
