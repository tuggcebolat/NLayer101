using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayer.Core.DTOs;

namespace NLayer.API.Filters
{
    
    public class ValidateFilterAttribute :ActionFilterAttribute 
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //fluentvalidator kütüphanesi    ,context üzerinden gelen modelstate de entegredir, fluentvalidation kullanmasakta validation hataları görmek için isvalid üzerinden kontrol edebiliriz.
            if(!context.ModelState.IsValid) //bir hata var ise
            {
                var errors= context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();

                context.Result = new BadRequestObjectResult(CustomResponseDto<NoContentDto>.Fail(400, errors));
              
               
            }
        }
    }
}
