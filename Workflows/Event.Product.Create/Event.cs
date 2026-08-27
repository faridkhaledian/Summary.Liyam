using Core.Workflows.Abstractions.Models;
using Core.Workflows.Activities;
using Core.Workflows.Models;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace Summary.Liyam.Workflows.Event.Product.Create
{
    public class CreateProductInLiyamEvent : EventActivity
    {
        private readonly IStringLocalizer<CreateProductInLiyamEvent> T;

        public CreateProductInLiyamEvent(
            IStringLocalizer<CreateProductInLiyamEvent> t)
        {
            T = t;
        }

        public override string Name => nameof(CreateProductInLiyamEvent);

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