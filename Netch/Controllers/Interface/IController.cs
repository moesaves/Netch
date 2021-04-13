namespace Netch.Controllers.Interface
{
    public interface IController
    {
        bool Create(Models.Servers.Server s, Models.Mode.Mode m);
        bool Delete();
    }
}
