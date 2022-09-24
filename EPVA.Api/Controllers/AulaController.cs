using EPVA.Application.GestaoCurso.Dto;
using EPVA.Application.GestaoCurso.Handler.Command;
using EPVA.Application.GestaoCurso.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPVA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaController : ControllerBase
    {
        private readonly IMediator mediator;

        public AulaController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos([FromQuery(Name = "page")] string page = "1")
        {
            var result = await mediator.Send(new GetAllAulaQuery());
            return Ok(result);
        }

        [Route("{id?}")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await mediator.Send(new GetAulaQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(AulaInputDto dto)
        {
            var result = await mediator.Send(new CreateAulaCommand(dto));
            return Created($"{result.Aula.Id}", result.Aula);
        }

        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, AulaInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await mediator.Send(new EditAulaCommand(id, dto));

            return Ok(result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            await mediator.Send(new DeleteAulaCommand(id));

            return NoContent();
        }
    }
}
