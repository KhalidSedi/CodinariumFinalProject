﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using FluentValidation.Results; 

namespace Core.Extensions
{
    public static class Extensions
    {
        public static void AddToModelState(this ValidationResult result, ModelStateDictionary modelState)
        {
            foreach(var error in result.Errors)
            {
                modelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
    }
}
