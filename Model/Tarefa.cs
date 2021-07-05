using System;

namespace desafio_ciet.Model
{
    
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Aberto { get; private set; }
        public Tarefa(string descricao)
        {
            if(descricao == "" || descricao == null)
            {
                throw new ArgumentException("Novas tarefas precisam de uma descrição válida.");
            }
            Descricao = descricao;
            Aberto = "true";
            ;
        }

        public void Fechar()
        {
            Aberto = "false";
        }
    }
}
