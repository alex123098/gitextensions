using EnvDTE;

namespace GitPlugin.Commands
{
	public sealed class SvnRebase : ItemCommandBase
	{
		protected override void OnExecute(SelectedItem item, string fileName, OutputWindowPane pane) 
		{
			RunGitEx("svn-rebase", fileName);
		}

		protected override CommandTarget SupportedTargets 
		{
			get { return CommandTarget.SolutionExplorerFileItem; }
		}
	}
}
