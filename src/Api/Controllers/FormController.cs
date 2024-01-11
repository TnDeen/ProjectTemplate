using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTemplate.Application.ApplicationForms.StandardMarginLoans.Command;
using ProjectTemplate.Core.Api;

namespace Api.Controllers
{
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("api/v{version:apiVersion}/[controller]s")]
    public class FormController : ControllerBase
    {
        private readonly ISender _mediator;

        public FormController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Tell me what this endpoint do
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResult<Guid>>> Post([FromBody] ProcessStandardMarginLoanApplicationCommand request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            var apiresult = ApiResult<Guid>.Create(result);
            return Created($"/forms/{request.IdentityNumber}", apiresult);
        }

        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResult<Guid>>> PostV2([FromBody] ProcessStandardMarginLoanApplicationCommand request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            var apiresult = ApiResult<Guid>.Create(result);
            return Created($"/forms/{request.IdentityNumber}", apiresult);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResult<Guid>>> Get([FromBody] ProcessStandardMarginLoanApplicationCommand request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            var apiresult = ApiResult<Guid>.Create(result);
            return Created($"/forms/{request.IdentityNumber}", apiresult);
        }
    }
}
