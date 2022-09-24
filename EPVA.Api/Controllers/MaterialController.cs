using EPVA.Application.GestaoCurso.Dto;
using EPVA.Application.GestaoCurso.Handler.Command;
using EPVA.Application.GestaoCurso.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPVA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IMediator mediator;

        public MaterialController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos([FromQuery(Name = "page")] string page = "1")
        {
            var result = await mediator.Send(new GetAllMaterialQuery());
            return Ok(result);
        }

        [Route("{id?}")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await mediator.Send(new GetMaterialQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(MaterialInputDto dto)
        {
            var result = await mediator.Send(new CreateMaterialCommand(dto));
            return Created($"{result.Material.Id}", result.Material);
        }

        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, MaterialInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await mediator.Send(new EditMaterialCommand(id, dto));

            return Ok(result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            await mediator.Send(new DeleteMaterialCommand(id));

            return NoContent();
        }
    }
}
