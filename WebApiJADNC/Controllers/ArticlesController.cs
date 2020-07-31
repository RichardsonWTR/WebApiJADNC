using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebApiJADNC.Models;

namespace WebApiJADNC.Controllers
{
    public sealed class ArticlesController : JsonApiController<Article>
    {
        public ArticlesController(
            IJsonApiContext jsonApiOptions,
            ILoggerFactory loggerFactory,
            IResourceService<Article> resourceService)
            : base(jsonApiOptions, resourceService, loggerFactory)
        { }
    }
}