using System.Threading.Tasks;

namespace PK.BuildingBlocks.Infrasturcture
{
    public interface IUnitOfWork
    {
        int AffectedRows
        {
            get;
        }

        int Commit();

        Task<int> CommitAsync();
    }
}
