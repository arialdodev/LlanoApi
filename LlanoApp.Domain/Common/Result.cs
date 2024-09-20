namespace LlanoApp.Domain.Common
{
    public struct Result<T>
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public string Error { get; }
        public ErrorType ErrorType { get; }

        private Result(T value, bool isSuccess, string error)
        {
            Value = value;
            IsSuccess = isSuccess;
            Error = error;
        }
        private Result(T value, bool isSuccess, string error, ErrorType errorType)
        {
            Value = value;
            IsSuccess = isSuccess;
            Error = error;
            ErrorType = errorType;
        }

        public static Result<T> Success(T value)
        {
            return new Result<T>(value, true, null);
        }

        public static Result<T> Failure(string error, ErrorType errorType)
        {
            return new Result<T>(default, false, error, errorType);
        }

        public Result<TNext> Bind<TNext>(Func<T, Result<TNext>> next)
        {
            if (!IsSuccess)
            {
                return Result<TNext>.Failure(Error, ErrorType);
            }

            return next(Value);
        }
    }

    public enum ErrorType
    {
        None,           // No hay error
        Validation,     // Errores de validación
        NotFound,       // Recurso no encontrado
        Unauthorized,   // Acceso no autorizado
        Conflict,       // Conflicto con el estado del recurso
        Internal,       // Error interno del servidor
        Unknown         // Error desconocido
    }

}
