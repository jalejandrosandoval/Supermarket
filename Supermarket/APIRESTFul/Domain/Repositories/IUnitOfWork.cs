using System.Threading.Tasks;

namespace APIRESTFul.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }

}
