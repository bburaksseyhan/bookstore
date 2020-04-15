using System.Linq;

namespace BookStore.Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();

        void Add(T item);

        T Detail(int id);

        bool Remove(int id);
    }
}
