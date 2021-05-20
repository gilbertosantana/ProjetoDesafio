using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Repositorios
{
    public class CarroRepositorio : IRepositorio<Carro>
    {
        private FrotaContext context;

        public CarroRepositorio()
        {
            this.context = new FrotaContext();
        }

        public void CadastrarVeiculo(Carro carro)
        {
            try
            {
                this.context.Carros.Add(carro);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao cadastrar carro: {ex.Message}");
            }
        }

        public Carro ConsultarPorPlaca(string placa)
        {
            try
            {
                var carro = this.context.Carros.Find(placa);
                if (carro != null)
                {
                    return carro;
                }
                throw new Exception($"Nenhum veículo encontrado com a placa: {placa}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Carro> ConsultarPorFabricante(string fabricante)
        {
            try
            {
                var carros = this.context.Carros
                    .Where(x => x.Marca.Nome.ToUpper().Equals(fabricante.ToUpper()));
                if(carros != null && carros.Any())
                {
                    return carros.ToList();
                }
                throw new Exception($"Nenhum veículo encontrado com a marca: {fabricante}");
            }
            catch(Exception ex)
            {
                throw new Exception($"Marca não encontrada {ex.Message}");
            }
        }

        public List<Carro> ListarTodos()
        {
            return this.context.Carros.ToList();
        }

        public void Editar(Carro carro)
        {
            try
            {
                this.context.Update(carro);
                this.context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao editar veiculo {ex.Message}");
            }
        }

        public void Excluir(Carro carro)
        {
            try {
                this.context.Remove(carro);
                this.context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao excluir: {ex.Message}");
            }
        } 
    }
}
