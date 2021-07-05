using desafio_ciet.Model;
using System.Collections.Generic;
using System.Linq;

namespace desafio_ciet.Repository
{
    public class TarefaRepository : IRepository<Tarefa>
    {
        private readonly ApplicationContext _appContext;

        public TarefaRepository(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public void Create(Tarefa item)
        {
            _appContext.Tarefas_CIeT.Add(item);
            _appContext.SaveChanges();
        }

        public void Delete(Tarefa item)
        {
            _appContext.Tarefas_CIeT.Remove(item);
            _appContext.SaveChanges();
        }

        public List<Tarefa> Read()
        {
            return _appContext.Tarefas_CIeT.ToList();
        }

        public void Update(Tarefa item)
        {
            _appContext.Tarefas_CIeT.Update(item);
            _appContext.SaveChanges();
        }
    }
}
