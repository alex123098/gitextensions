using EnvDTE;

namespace GitPlugin.Commands
{
	public sealed class SvnDCommit : ItemCommandBase
	{
		protected override void OnExecute(SelectedItem item, string fileName, OutputWindowPane pane)
		{
			RunGitEx("svn-dcommit", fileName);
		}

		protected override CommandTarget SupportedTargets 
		{
			get { return CommandTarget.SolutionExplorerFileItem; }
		}
	}
}
