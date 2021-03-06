using GitHubSharp.Models;
using System.Threading.Tasks;

namespace CodeHub.ViewModels
{
    public class RepositoriesStarredViewModel : RepositoriesViewModel
    {
        public RepositoriesStarredViewModel()
            : base(string.Empty)
        {
        }

        public override Task Load(bool forceDataRefresh)
        {
            return Repositories.SimpleCollectionLoad(Application.Client.AuthenticatedUser.Repositories.GetStarred(), forceDataRefresh);
        }
    }
}

