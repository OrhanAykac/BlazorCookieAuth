using Business.Concrete;
using Business.Abstract;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using WebApp.Authentication;

namespace WebApp;

public static class RegisterServices
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddRazorComponents()
            .AddInteractiveServerComponents();
        
        services
            .ConfigureIoC()
            .ConfigureAuthentication();
    }

    private static IServiceCollection ConfigureAuthentication(this IServiceCollection services)
    {

        services.AddCascadingAuthenticationState();
        services.AddScoped<AuthenticationStateProvider, CustomRevalidatingAuthenticationStateProvider>();
        services.AddScoped<IdentityRedirectManager>();


        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Auth/Login";
                options.LogoutPath = "/Auth/Logout";
                options.ExpireTimeSpan = TimeSpan.FromHours(2);
                options.SlidingExpiration = true;
                options.ReturnUrlParameter = "returnUrl";
            });

        return services;
    }
    
    public static IServiceCollection ConfigureIoC(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserManager>();

        return services;
    }
}
