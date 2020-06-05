using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCalc.Entities
{
    class HourContract
    {
        //propriedades
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor padrão
        public HourContract()
        {

        }

        //Construtor com os três argumentos
        public HourContract(DateTime date, double valuePerHours, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHours;
            Hours = hours;
        }

        //método
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
