using Microsoft.Extensions.Localization;
using Core.Workflows.Abstractions.Models;
using Core.Workflows.Activities;
using Core.Workflows.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Summary.Liyam.Workflows.Event.Product.Create
{
    public class CreateProductEventInLiyam : EventActivity
    {
        private readonly IStringLocalizer<CreateProductEventInLiyam> T;

        public CreateProductEventInLiyam(
            IStringLocalizer<CreateProductEventInLiyam> t)
        {
            T = t;
        }

        public override string Name => nameof(CreateProductEventInLiyam);

        public override LocalizedString DisplayText => T[Liyam.Localize.SOfCreateProductEvent];

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