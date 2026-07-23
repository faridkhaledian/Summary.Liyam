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
    [EnableCors("Everywhere")]
    [Route("api/v1/liyam/product")]
    public class Product : ControllerBase
    {
        private readonly IWorkflowManager _workflowManager;
        public Product(
            IWorkflowManager workflowManager)
        {
            _workflowManager = workflowManager;
        }

        [HttpPost, Route("[action]")]
        public async Task<IActionResult> Submit([FromBody] ProductSubmitModel model)
        {
            await RaiseSubmitOrder(model);

            return Ok();
        }

        private async Task RaiseSubmitOrder(ProductSubmitModel model)
        {
            var inputs = new Dictionary<string, object>
            {
                { "Liyam.Product.Id", model.Entity.FullCode },
                 { "Liyam.Product.Title", model.Entity.Title },
                 { "Liyam.Product.Category", model.Entity.GoodsGroup_Title }
            };

            var eventName = model.ActionType == "Create"
            ? nameof(CreateProductEventInLiyam)
            : nameof(UpdateProductEventInLiyam);

            await _workflowManager.TriggerIntoDBAsync(eventName, inputs);
        }
    }
}