using Core.Workflows.Abstractions.Models;
using Core.Workflows.Activities;
using Core.Workflows.Models;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace Summary.Liyam.Workflows.Event.Product.Update
{
   public class UpdateProductEventInLiyamTask : EventActivity
    {
        private readonly IStringLocalizer<UpdateProductEventInLiyamTask> T;

        public UpdateProductEventInLiyamTask(
            IStringLocalizer<UpdateProductEventInLiyamTask> t)
        {
            T = t;
        }

        public override string Name => nameof(UpdateProductEventInLiyamTask);

        public override LocalizedString DisplayText => T[Liyam.Localize.SOfUpdateProduct];

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

