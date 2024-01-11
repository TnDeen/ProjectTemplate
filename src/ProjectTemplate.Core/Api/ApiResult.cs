using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Core.Api
{
    public class ApiResult<T>
    {
        public ApiResult(T data)
        {
            Data = data;
        }

        public T Data { get; }
        public int StatusCode { get; }
        public Dictionary<string, string>? Meta { get; }

        public static ApiResult<T> Create(T data)
        {
            return new ApiResult<T>(data);
        }
    }
}
