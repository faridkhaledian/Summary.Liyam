using Core.Workflows.Abstractions.Models;
using Core.Workflows.Activities;
using Core.Workflows.Models;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace Summary.Liyam.Workflows.Event.Identity.Create
{
    public class CreateIdentityInLiyamEvent : EventActivity
    {
        private readonly IStringLocalizer<CreateIdentityInLiyamEvent> T;

        public CreateIdentityInLiyamEvent(
            IStringLocalizer<CreateIdentityInLiyamEvent> t)
        {
            T = t;
        }

        public override string Name => nameof(CreateIdentityInLiyamEvent);

        public override LocalizedString DisplayText => T[Liyam.Localize.SOfCreateIdentity];

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