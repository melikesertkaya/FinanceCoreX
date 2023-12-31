﻿using FinanceCoreX.Shared.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceCoreX.Shared.Extensions
{
    //Bu kod, uygulamanın doğrulama sırasında geçersiz
    //model durumunda özel bir yanıt döndürmesini sağlar.
    //Özellikle API'lerde, istemcilere geçersiz girişleri
    //daha iyi anlamaları için özelleştirilmiş bir yanıt
    //göndermek için kullanılabilir. Bu sayede istemcilerin,
    //doğrulama hatası durumunda hangi hataların oluştuğunu
    //daha net bir şekilde görmeleri sağlanabilir.
    public static class CustomValidationResponse
    {
        public static void UseCustomValidationResponse(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState.Values.Where(x => x.Errors.Count > 0).SelectMany(x => x.Errors).Select(x => x.ErrorMessage);

                    var response = new Response<NoDataResponse>(ResultStatus.Error, errors.ToList());

                    return new BadRequestObjectResult(response);
                };
            });
        }
    }
}
