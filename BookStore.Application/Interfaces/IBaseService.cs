using BookStore.Application.Response;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface IBaseService<RequestParam, ResponseParam, Id> where RequestParam : new()
    {
        IEnumerable<ResponseParam> GetAll();

        void Add(RequestParam item);

        BaseResponse<bool> Remove(Id id);

        BaseResponse<ResponseParam> Detail(Id id);
    }
}
