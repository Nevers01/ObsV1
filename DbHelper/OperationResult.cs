using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper
{
    public class OperationResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public OperationResult()
        { }

        protected OperationResult(bool isSuccess, string message) // <--- protected olmalı
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public static OperationResult Success(string message)
        {
            return new OperationResult(true, message);
        }

        public static OperationResult Failure(string message)
        {
            return new OperationResult(false, message);
        }
    }

    public class OperationResult<T> : OperationResult
    {
        public T Data { get; set; }

        public OperationResult()
        { }

        private OperationResult(bool isSuccess, string message, T data)
            : base(isSuccess, message) // Şimdi burada sorun yok
        {
            Data = data;
        }

        public static OperationResult<T> Success(string message, T data)
        {
            return new OperationResult<T>(true, message, data);
        }

        public static OperationResult<T> Failure(string message)
        {
            return new OperationResult<T>(false, message, default(T));
        }
    }
}