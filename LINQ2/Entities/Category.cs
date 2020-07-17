using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ2.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; } //É uma classificação de categoria 1 ótimo 2 bom ...
    }
}
