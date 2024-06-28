﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Billing.Management.Infra.CrossCutting.Extensions.ExceptionHandlers
{
    internal sealed class ExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<ExceptionFilter>? _logger;

        public ExceptionFilter(ILogger<ExceptionFilter>? logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger?.LogError(context.Exception, context.Exception.Message);

            var statusCode = context.Exception.Message.Contains("Try") ? 404 : 400;

            context.Result = new ObjectResult(context)
            {
                StatusCode = statusCode,
                Value = new
                {
                    ResponseCode = statusCode,
                    ResponseMessage = context.Exception.Message
                }
            };
        }
    }
}