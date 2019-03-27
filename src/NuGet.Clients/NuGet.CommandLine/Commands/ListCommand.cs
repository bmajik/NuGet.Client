using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.CommandLine.Commands
{
    [Command(
        typeof(NuGetCommand),
        "list",
        "ListCommandDescription",
        UsageSummaryResourceName = "ListCommandUsageSummary",
        UsageDescriptionResourceName = "ListCommandUsageDescription",
        UsageExampleResourceName = "ListCommandUsageExamples")]
    [Obsolete(message:"Use SearchCommand class. This class will disappear in upcoming releases", error: false)]
    public class ListCommand : SearchCommand
    {
        public async override Task ExecuteCommandAsync()
        {
            Console.WriteWarning(LocalizedResourceManager.GetString("ListCommandDeprecatedMessage"));
            await base.ExecuteCommandAsync();
        }
    }
}
