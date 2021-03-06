using JetBrains.ReSharper.Feature.Services.ContextActions;
using JetBrains.ReSharper.Feature.Services.CSharp.Analyses.Bulbs;
using JetBrains.Util;
using Resharper.QuickActions.Actions.Base;
using Resharper.QuickActions.Helpers;
using Resharper.QuickActions.Models;

namespace Resharper.QuickActions.Actions
{
    [ContextAction(Name = ActionName, Description = "Clones selected method", Group = "C#")]
    public class CloneMethod : ClonableContextAction
    {
        const string ActionName = "Clone method";

        public CloneMethod(ICSharpContextActionDataProvider provider) : base(ActionName, provider)
        {
        }

        public override bool IsAvailable(IUserDataHolder bag)
        {
            var context = GetContext();
            return context?.SelectedMember?.IsMethod() == true && context.SelectedMemberPart == SelectedMemberPart.Name;
        }
    }
}