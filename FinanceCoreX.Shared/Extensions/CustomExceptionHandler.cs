using FinanceCoreX.Shared.Response;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace FinanceCoreX.Shared.Extensions
{
    //Bu özel istisna yöneticisi, bir istemcinin sunucudaki
    //bir istek sırasında oluşan istisnaları daha anlamlı bir
    //şekilde işlemesine yardımcı olabilir. Özellikle API'lerde,
    //istemcilere hatayı daha iyi anlamaları için özelleştirilmiş
    //bir yanıt göndermek için kullanılabilir.
    public static class CustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {

            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";

                    var errorFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (errorFeature != null)
                    {
                        var ex = errorFeature.Error;

                        var response = new Response<NoDataResponse>(ResultStatus.Error, ex.Message);

                        await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                    }
                });
            });
        }
    }
}
