using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReverieCore.ExceptionHandler.Business;
public sealed class BusinessErrorDetails : ProblemDetails
{
    public BusinessErrorDetails(string message)
    {
        Status = StatusCodes.Status400BadRequest;
        Type = "Business Exception";
        Title = "Business Error";
        Detail = message;
    }
}