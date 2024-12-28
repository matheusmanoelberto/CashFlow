using System.Globalization;

namespace CashFlow.Api.Middleware;

public class CultureMiddleware
{
    private readonly RequestDelegate _next;
    public CultureMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
       var supportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();

       var requestedCuture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

        var cultureInfo = new CultureInfo("en");

        if(string.IsNullOrWhiteSpace(requestedCuture) == false 
            && supportedLanguages.Exists(language => language.Equals(requestedCuture))) 
        { 
            cultureInfo = new CultureInfo(requestedCuture);
        }

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        await _next(context);
    }
}
