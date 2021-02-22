using System.Linq;

namespace GoltaraSolutions.Common.Infra.Repository
{
    public interface IDbSet<TEntity> : IQueryable<TEntity>
    {
    }
}
