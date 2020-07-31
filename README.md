# Web API with JSON:API specification

## About

This is a web API project using JSON:API spec. I intend to accomplish this by using the library JsonApiDotNetCore (also known as JADNC).

I'm struggling with the JADNC docs so the intention of this repo is to search for help.

This is the most basic example I can think about. Actually most part of the code in this example was borrowed from JADNC docs itself.

## What's the problem

When I run the project the following error is thrown:

```
An error occurred while starting the application.
InvalidOperationException: Endpoint Routing does not support 'IApplicationBuilder.UseMvc(...)'. To use 'IApplicationBuilder.UseMvc' set 'MvcOptions.EnableEndpointRouting = false' inside 'ConfigureServices(...).
Microsoft.AspNetCore.Builder.MvcApplicationBuilderExtensions.UseMvc(IApplicationBuilder app, Action<IRouteBuilder> configureRoutes)

InvalidOperationException: Endpoint Routing does not support 'IApplicationBuilder.UseMvc(...)'. To use 'IApplicationBuilder.UseMvc' set 'MvcOptions.EnableEndpointRouting = false' inside 'ConfigureServices(...).
Microsoft.AspNetCore.Builder.MvcApplicationBuilderExtensions.UseMvc(IApplicationBuilder app, Action<IRouteBuilder> configureRoutes)
Microsoft.AspNetCore.Builder.MvcApplicationBuilderExtensions.UseMvc(IApplicationBuilder app)
JsonApiDotNetCore.Extensions.IApplicationBuilderExtensions.UseJsonApi(IApplicationBuilder app, bool useMvc)
WebApiJADNC.Startup.Configure(IApplicationBuilder app, AppDbContext context) in Startup.cs
+
            app.UseJsonApi();
System.RuntimeMethodHandle.InvokeMethod(object target, object[] arguments, Signature sig, bool constructor, bool wrapExceptions)
System.Reflection.RuntimeMethodInfo.Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
Microsoft.AspNetCore.Hosting.ConfigureBuilder.Invoke(object instance, IApplicationBuilder builder)
Microsoft.AspNetCore.Hosting.ConfigureBuilder+<>c__DisplayClass4_0.<Build>b__0(IApplicationBuilder builder)
Microsoft.AspNetCore.Hosting.GenericWebHostBuilder+<>c__DisplayClass13_0.<UseStartup>b__2(IApplicationBuilder app)
Microsoft.AspNetCore.Mvc.Filters.MiddlewareFilterBuilderStartupFilter+<>c__DisplayClass0_0.<Configure>g__MiddlewareFilterBuilder|0(IApplicationBuilder builder)
Microsoft.AspNetCore.Server.IIS.Core.IISServerSetupFilter+<>c__DisplayClass2_0.<Configure>b__0(IApplicationBuilder app)
Microsoft.AspNetCore.HostFilteringStartupFilter+<>c__DisplayClass0_0.<Configure>b__0(IApplicationBuilder app)
Microsoft.AspNetCore.Hosting.GenericWebHostService.StartAsync(CancellationToken cancellationToken)
Microsoft.Extensions.Hosting.Internal.Host.StartAsync(CancellationToken cancellationToken)
Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.Run(IHost host)
WebApiJADNC.Program.Main(string[] args) in Program.cs
+
            CreateHostBuilder(args).Build().Run();
```

## Contribute!

Feel free to fork, share, edit this repo and help me solve this issue.  
I'll convert the acquired knowledge to improve the docs and avoid people getting stuck with the same error.

## Reference links

- [JSON:API — A specification for building APIs in JSON](https://jsonapi.org/)
- [JsonApiDotNetCore - A json:api web application framework for .NET Core.](https://json-api-dotnet.github.io/JsonApiDotNetCore/index.html)
