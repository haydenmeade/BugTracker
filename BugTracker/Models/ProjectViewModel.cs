namespace BugTracker.Models
{
    public class ProjectViewModel
    {

        public ProjectViewModel(Project project)
        {
            Project = project;
        }

        public Project Project { get; }
    }
}