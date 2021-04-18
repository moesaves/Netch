using Netch.Models.Server;

namespace Netch.Controllers.Interface
{
    public interface IController
    {
        bool Create(Server s, Models.Mode.Mode m);

        bool Delete();
    }
}
