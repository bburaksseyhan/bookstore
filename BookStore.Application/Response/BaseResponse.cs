namespace BookStore.Application.Response
{
    public class BaseResponse
    {
     
    }

    public class BaseResponse<T> : BaseResponse
    {
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public string[] Errors { get; set; }
    }
}
