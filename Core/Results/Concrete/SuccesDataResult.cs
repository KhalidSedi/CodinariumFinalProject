namespace Core.Results.Concrete
{
    public class SuccesDataResult<T> : DataResult<T>
    {
        public SuccesDataResult(T data) : base(data, true)
        {
        }

        public SuccesDataResult(T data, string message) : base(data, message, true)
        {
        }
    }
}
