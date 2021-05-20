using System.Collections.Generic;

namespace Backend.Repositorios
{
    public interface IRepositorio<T>
    {
        public void CadastrarVeiculo(T entidade);
        public T ConsultarPorPlaca(string placa);
        public List<T> ConsultarPorFabricante(string fabricante);
        public List<T> ListarTodos();
        public void Editar(T entidade);
        public void Excluir(T endidade);
    }
}