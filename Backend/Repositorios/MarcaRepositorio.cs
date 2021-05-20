using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repositorios
{
    public class MarcaRepositorio
    {
        private FrotaContext context;

        public MarcaRepositorio()
        {
            this.context = new FrotaContext();
        }

        public void Cadastrar(Marca entidade)
        {
            try
            {
                this.context.Set<Marca>().Add(entidade);
                this.context.SaveChanges();
            
            }
            catch(Exception ex)
            {
                throw new Exception($"Falha ao cadastrar: {ex.Message}");
            }
        }

        public void Editar(Marca entidade)
        {
            try
            {
                this.context.Set<Marca>().Update(entidade);
                this.context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception($"Falha ao atualizar: {ex.Message}");
            }
        }

        public void Excluir(Marca marca)
        {
            try
            {
                this.context.Set<Marca>().Remove(marca);
                this.context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception($"Não foi possível excluir a marca {marca.Nome}: {ex.Message}");
            }
        }

        public Marca ObterPorId(int id)
        {
            return this.context.Set<Marca>().Find(id);
        }

        public List<Marca> ObterTodos()
        {
            return this.context.Set<Marca>().ToList();
        }
    }
}
