using System.Linq;

namespace BookStore.Domain.Interfaces
{
    public interface IBaseRepository<T, K>
    {
        IQueryable<T> GetAll();

        void Add(T item);

        T Detail(K id);

        bool Remove(K id);

        bool Edit(K id, T item);
    }
}
