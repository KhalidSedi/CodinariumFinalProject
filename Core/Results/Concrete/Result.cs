﻿using Core.Results.Abstract;

namespace Core.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;   
        }

        public Result(string message, bool isSuccess) : this(isSuccess)
        {
            Message = message;
        }
        public string Message { get; }

        public bool IsSuccess {  get; }
    }
}
