using EPVA.Application.PlanoAula.Dto;
using EPVA.Application.PlanoAula.Handler.Command;
using EPVA.Application.PlanoAula.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPVA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProfessorController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos([FromQuery(Name = "page")] string page = "1")
        {
            var result = await mediator.Send(new GetAllProfessorQuery());
            return Ok(result);
        }

        [Route("{id?}")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await mediator.Send(new GetProfessorQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(ProfessorInputDto dto)
        {
            var result = await mediator.Send(new CreateProfessorCommand(dto));
            return Created($"{result.Professor.Id}", result.Professor);
        }

        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, ProfessorInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await mediator.Send(new EditProfessorCommand(id, dto));

            return Ok(result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            await mediator.Send(new DeleteProfessorCommand(id));

            return NoContent();
        }
    }
}
