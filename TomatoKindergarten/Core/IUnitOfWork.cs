using System.Threading.Tasks;

namespace TomatoKindergarten.Core
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}