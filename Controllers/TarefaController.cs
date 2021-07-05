using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using desafio_ciet.Model;
using desafio_ciet.Repository;
using System;
using System.Linq;

namespace desafio_ciet.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TarefaController : ControllerBase
    {
        private readonly IRepository<Tarefa> _tarefaRepository;

        public TarefaController(IRepository<Tarefa> usuarioRepository)
        {
            _tarefaRepository = usuarioRepository;
        }

        [HttpGet("ListarTarefas")]
        public ActionResult ListarTarefasAsync()
        {
            var tarefas = _tarefaRepository.Read().ToArray();
            if (tarefas.Length == 0)
            {
                return NotFound(new { status= "Falha", message= "Nenhuma tarefa Cadastrada." } );
            }
            return Ok(JsonConvert.SerializeObject(tarefas));
        }

        [HttpGet("NovaTarefa/{descricao}")]
        public ActionResult NovaTarefa([FromRoute] string descricao)
        {
            try
            {
                _tarefaRepository.Create(new Tarefa(descricao));
                return Ok(new { status = "Sucesso!", message = "Tarefa cadastrada com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { status = "Erro: ", message = $"Não foi possível criar a tarefa. {ex.Message}" });
            }
        }

        [HttpGet("EditarTarefa/{id}/{novaDescricao}")]
        public ActionResult EditarTarefa([FromRoute] string novaDescricao, [FromRoute] int id)
        {
            bool status = false;
            foreach (var item in _tarefaRepository.Read().ToList())
            {
                if (item.Id == id)
                {
                    item.Descricao = novaDescricao;
                    _tarefaRepository.Update(item);
                    status = true;
                }
            }

            if (!status)
            {
                return BadRequest(new { status = "Falha", message= "Não foi possível alterar a tarefa com o Id informado." } );
            }
            return Ok(new { status = "Sucesso", message = "A Tarefa foi atualizada." });
        }

        [HttpGet("RemoverTarefa/{id}")]
        public ActionResult RemoverTarefa([FromRoute] int id)
        {
            bool status = false;
            foreach (var item in _tarefaRepository.Read().ToList())
            {
                if (item.Id == id)
                {
                    _tarefaRepository.Delete(item);
                    status = true;
                }
            }

            if (!status)
            {
                return BadRequest(new { status = "Falha", message = "Não foi possível remover a Tarefa com o ID informado."});
            }
            return Ok(new { status = "Sucesso", message = "A Tarefa solicitada foi removida." });
        }

        [HttpGet("FinalizarTarefa/{id}")]
        public ActionResult FinalizarTarefa([FromRoute] int id)
        {
            bool status = false;
            foreach (var item in _tarefaRepository.Read().ToList())
            {
                if(item.Id == id)
                {
                    item.Fechar();
                    _tarefaRepository.Update(item);
                    status = true;
                }
            }
            if (!status)
            {
                return BadRequest(new { status = "Erro", message = "Não foi possível encontrar a tarefa solicitada." });
            }
            return Ok(new { status="Sucesso", message = $"A tarefa {id} foi finalizada com sucesso!"});
        }
    }
}
