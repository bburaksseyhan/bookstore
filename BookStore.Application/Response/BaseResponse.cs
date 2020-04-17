namespace BookStore.Application.Response
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public string[] Errors { get; set; }
    }
}
