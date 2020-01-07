using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;

namespace BuildProject
{
    [CheckBuildProjectConfigurations]
    [UnsetVisualStudioEnvironmentVariables]
    [DotNetVerbosityMapping]
    [MSBuildVerbosityMapping]
    public class Builder : NukeBuild
    {
        public static int Main() => Execute<Builder>(x => x.Compile);
        
        [Solution]
        protected readonly Solution Solution;
       
        Target Compile => _ => _
            .Executes(() =>
                {
                    
                });
    }
}