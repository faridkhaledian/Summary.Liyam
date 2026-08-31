using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Core.Workflows.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Summary.Liyam;
using Summary.Liyam.Workflows.Event.Identity.Update;
using Summary.Liyam.Workflows.Event.Identity.Create;

namespace Summary.Liyam.Controllers.Api.V1
{
    [ApiController]
    [AllowAnonymous]
    [IgnoreAntiforgeryToken]
    [Authorize(AuthenticationSchemes = "Api")]
    [Route("api/v1/liyam/identity")]
    public class IdentityController : ControllerBase
    {
        private readonly IWorkflowManager _workflowManager;
        public IdentityController(
            IWorkflowManager workflowManager)
        {
            _workflowManager = workflowManager;
        }

        [HttpPost, Route("[action]")]
        public async Task<IActionResult> Submit([FromBody] IdentitySubmitModel model)
        {
            var inputs = new Dictionary<string, object>
            {
                { "Liyam.Identity.Id", model.Entity.DetailId },
                { "Liyam.Identity.Code", model.Entity.FullCode },
                { "Liyam.Identity.Title", model.Entity.Title },
                { "Liyam.Identity.Category", model.Entity.DetailGroupTitle },
                { "Liyam.Identity.Type", model.Entity.Person_PersonTypeStr },
                { "Liyam.Identity.NationalCode", model.Entity.Person_NationalCode },
                { "Liyam.Identity.Mobile", model.Entity.Person_Mobile },
                { "Liyam.Identity.Email", model.Entity.Person_Email }
            };

            var event_name = model.ActionType.ToLower() == "create" ?
                nameof(CreateIdentityInLiyamEvent) :
                nameof(UpdateIdentityInLiyamEvent);

            await _workflowManager.TriggerIntoDBAsync(event_name, inputs);

            return Ok();
        }
    }
}