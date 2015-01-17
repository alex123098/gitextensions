using EnvDTE;

namespace GitPlugin.Commands
{
	public sealed class SvnFetch : ItemCommandBase
	{
		protected override void OnExecute(SelectedItem item, string fileName, OutputWindowPane pane) 
		{
			RunGitEx("svn-fetch", fileName);
		}

		protected override CommandTarget SupportedTargets
		{
			get { return CommandTarget.SolutionExplorerFileItem; }
		}
	}
}
