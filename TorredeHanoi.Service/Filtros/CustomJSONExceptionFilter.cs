﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorredeHanoi.Service.Filtros
{
    public class CustomJSONExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.HttpContext.Request.GetTypedHeaders().Accept.Any(header => header.MediaType == "application/json"))
            {
                var jsonResult = new JsonResult(new { error = context.Exception.Message });
                jsonResult.StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status500InternalServerError;
                context.Result = jsonResult;
            }
        }


    }
}
