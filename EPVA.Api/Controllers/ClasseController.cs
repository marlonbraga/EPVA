using EPVA.Application.PlanoAula.Dto;
using EPVA.Application.PlanoAula.Handler.Command;
using EPVA.Application.PlanoAula.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPVA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasseController : ControllerBase
    {
        private readonly IMediator mediator;

        public ClasseController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos([FromQuery(Name = "page")] string page = "1")
        {
            var result = await mediator.Send(new GetAllClasseQuery());
            return Ok(result);
        }

        [Route("{id?}")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await mediator.Send(new GetClasseQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(ClasseInputDto dto)
        {
            var result = await mediator.Send(new CreateClasseCommand(dto));
            return Created($"{result.Classe.Id}", result.Classe);
        }

        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, ClasseInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await mediator.Send(new EditClasseCommand(id, dto));

            return Ok(result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            await mediator.Send(new DeleteClasseCommand(id));

            return NoContent();
        }
    }
}
