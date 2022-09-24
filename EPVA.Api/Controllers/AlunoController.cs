using EPVA.Application.PlanoAula.Dto;
using EPVA.Application.PlanoAula.Handler.Command;
using EPVA.Application.PlanoAula.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPVA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IMediator mediator;

        public AlunoController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos([FromQuery(Name = "page")] string page = "1")
        {
            var result = await mediator.Send(new GetAllAlunoQuery());
            return Ok(result);
        }

        [Route("{id?}")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await mediator.Send(new GetAlunoQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(AlunoInputDto dto)
        {
            var result = await mediator.Send(new CreateAlunoCommand(dto));
            return Created($"{result.Aluno.Id}", result.Aluno);
        }

        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, AlunoInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await mediator.Send(new EditAlunoCommand(id, dto));

            return Ok(result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            await mediator.Send(new DeleteAlunoCommand(id));

            return NoContent();
        }
    }
}
