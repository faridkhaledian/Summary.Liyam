using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Core.Workflows.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Summary.Liyam;
using Summary.Liyam.Workflows.Event.Product.Update;
using Summary.Liyam.Workflows.Event.Product.Create;

namespace Summary.Liyam.Controller.Api.V1
{
    [ApiController]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    [Authorize(AuthenticationSchemes = "Api")]
    [Route("api/v1/liyam/product")]
    public class ProductController : ControllerBase
    {
        private readonly IWorkflowManager _workflowManager;
        public ProductController(
            IWorkflowManager workflowManager)
        {
            _workflowManager = workflowManager;
        }

        [HttpPost, Route("[action]")]
        public async Task<IActionResult> Submit([FromBody] ProductSubmitModel model)
        {
            var inputs = new Dictionary<string, object>
            {
                { "Liyam.Product.Id", model.Entity.GoodsId },
                { "Liyam.Product.Code", model.Entity.FullCode },
                { "Liyam.Product.Title", model.Entity.Title },
                { "Liyam.Product.Category", model.Entity.GoodsGroup_Title }
            };

            var event_name = model.ActionType.ToLower() == "create" ?
                nameof(CreateProductEventInLiyamTask) :
                nameof(UpdateProductEventInLiyamTask);

            await _workflowManager.TriggerIntoDBAsync(event_name, inputs);

            return Ok();
        }
    }
}