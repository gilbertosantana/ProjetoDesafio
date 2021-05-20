using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Carro> Carro { get; set; }

        public virtual ICollection<Moto> Moto { get; set; }

    }
}
