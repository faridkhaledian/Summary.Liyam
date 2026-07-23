using Microsoft.Extensions.Localization;
using Core.Workflows.Abstractions.Models;
using Core.Workflows.Activities;
using Core.Workflows.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Summary.Liyam.Workflows.Event.Product.Update
{
   public class UpdateProductEventInLiyam : EventActivity
    {
        private readonly IStringLocalizer<UpdateProductEventInLiyam> T;

        public UpdateProductEventInLiyam(
            IStringLocalizer<UpdateProductEventInLiyam> t)
        {
            T = t;
        }

        public override string Name => nameof(UpdateProductEventInLiyam);

        public override LocalizedString DisplayText => T[Liyam.Localize.SOfUpdateProductEvent];

        public override LocalizedString Category => T[Liyam.Public.Category];

        public override IEnumerable<Outcome> GetPossibleOutcomes(
            WorkflowExecutionContext workflowContext,
            ActivityContext activityContext)
        {
            return Outcomes(T[Liyam.Workflows.Done]);
        }

        public override async Task<ActivityExecutionResult> ResumeAsync(
            WorkflowExecutionContext workflowContext,
            ActivityContext activityContext)
        {
            return Outcomes(Liyam.Workflows.Done);
        }
    }

}

