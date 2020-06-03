using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace AumentoSalarioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários irá registrar? ");
            int QntFuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Funcionario> funcionarios = new List<Funcionario>();
            for (int i = 0; i < QntFuncionario; i++)
            {
                Console.WriteLine("Funcionario #" + (i + 1));
                Console.Write("ID:  ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine("");
            }
            Console.Write("Entre com o Id do funcionario que deseja aumentar o salario: ");
            int idAlterar = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (funcionarios.Exists(x => x.Id == idAlterar))
            {
                foreach (Funcionario obj in funcionarios)
                {

                    if (obj.Id == idAlterar)
                    {
                        Console.Write("Porcentagem de aumento: ");
                        obj.AumentarSalario(int.Parse(Console.ReadLine()));
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Funcionario não existe!");
            }
            Console.WriteLine("");
            Console.WriteLine("Atualizações da lista funcionarios: ");
            foreach (Funcionario obj in funcionarios)
                Console.WriteLine(obj.Id + " " + obj.Nome + " " + obj.Salario);

            Console.ReadLine();
        }
    }
}
