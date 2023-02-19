﻿using Microsoft.AspNetCore.Builder;

namespace ReverieCore.ExceptionHandler;

public static class ExceptionMiddlewareExtension
{
    public static void UseExceptionMiddleware(this IApplicationBuilder applicationBuilder) => applicationBuilder.UseMiddleware<ExceptionMiddleware>();
}