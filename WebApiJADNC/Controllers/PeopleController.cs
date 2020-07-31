
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebApiJADNC.Models;

namespace WebApiJADNC.Controllers
{
    public sealed class PeopleController : JsonApiController<Person>
    {
        public PeopleController(
            IJsonApiContext jsonApiOptions,
            ILoggerFactory loggerFactory,
            IResourceService<Person> resourceService)
        : base(jsonApiOptions, resourceService, loggerFactory)
        { }
    }
}