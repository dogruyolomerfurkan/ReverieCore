using Microsoft.AspNetCore.Mvc;
using ReverieCore.ExceptionHandler.Authorization;
using ReverieCore.ExceptionHandler.Business;
using ReverieCore.ExceptionHandler.Internal;
using ReverieCore.ExceptionHandler.Validation;

namespace ReverieCore.ExceptionHandler;

public static class ErrorResponseFactory
{
    public static ProblemDetails CreateErrorReponse(Exception exception)
    {
        ProblemDetails response = exception switch
        {
            AuthorizationException => new AuthorizationErrorDetails(exception.Message),
            BusinessException => new BusinessErrorDetails(exception.Message),
            ValidationException => new ValidationErrorDetails(exception),
            _ => new InternalErrorDetails(exception.Message)
        };

        return response;
    }
}