﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReverieCore.ExceptionHandler.Authorization;
public sealed class AuthorizationErrorDetails : ProblemDetails
{
    public AuthorizationErrorDetails(string message)
    {
        Status = StatusCodes.Status401Unauthorized;
        Type = "Authorization Exception";
        Title = "Authorization Error";
        Detail = message;
    }
}