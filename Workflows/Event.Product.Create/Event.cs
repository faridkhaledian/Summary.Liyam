using Core.Workflows.Abstractions.Models;
using Core.Workflows.Activities;
using Core.Workflows.Models;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace Summary.Liyam.Workflows.Event.Product.Create
{
    public class CreateProductEventInLiyamTask : EventActivity
    {
        private readonly IStringLocalizer<CreateProductEventInLiyamTask> T;

        public CreateProductEventInLiyamTask(
            IStringLocalizer<CreateProductEventInLiyamTask> t)
        {
            T = t;
        }

        public override string Name => nameof(CreateProductEventInLiyamTask);

        public override LocalizedString DisplayText => T[Liyam.Localize.SOfCreateProduct];

        public override LocalizedString Category => T[Liyam.Public.Category];

        public override IEnumerable<Outcome> GetPossibleOutcomes(
            WorkflowExecutionContext workflowContext,
            ActivityContext activityContext)
        {
            return Outcomes(T[Liyam.Workflows.Done]);
        }

        public override ActivityExecutionResult Resume(
            WorkflowExecutionContext workflowContext,
            ActivityContext activityContext)
        {
            return Outcomes(Liyam.Workflows.Done);
        }
    }
}