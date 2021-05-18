using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Carro
    {
        public Carro(string nome, string modelo, string anoFabricacao, string cor, string placa)
        {
            this.Nome = nome;
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
            this.Cor = cor;
            this.Placa = placa;


        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Modelo { get; set; }

        public string AnoFabricacao { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

    
    }
}
