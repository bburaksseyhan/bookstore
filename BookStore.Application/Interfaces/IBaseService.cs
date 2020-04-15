using BookStore.Application.Response;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface IBaseService<T, K>
    {
        IEnumerable<T> GetAll();

        void Add(T item);

        BaseResponse<bool> Remove(K id);

        BaseResponse<T> Detail(K id);
    }
}
