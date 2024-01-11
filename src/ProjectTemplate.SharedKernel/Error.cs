using ProjectTemplate.SharedKernel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.SharedKernel
{
    public record Error(ErrorType ErrorType, string Code, string Description)
    {
        public static readonly Error None = new(ErrorType.None, string.Empty, string.Empty);
        public static readonly Error NullValue = new(ErrorType.Validation, "NullValue", "The value provided is null");

        public static Error Validation(string code, string description) =>
            new(ErrorType.Validation, code, description);

        public static Error NotFound(string code, string description) =>
            new(ErrorType.NotFound, code, description);

        public static Error Failure(string code, string description) =>
            new(ErrorType.Failure, code, description);

        public static Error Conflict(string code, string description) =>
            new(ErrorType.Conflict, code, description);

        public static implicit operator Result(Error error) => Result.Failure(error);

        public Result ToResult() => Result.Failure(this);
    }
}
