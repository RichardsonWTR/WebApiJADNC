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
     IJsonApiOptions options,
     ILoggerFactory loggerFactory,
     IGetAllService<Article, int> getAll = null,
     IGetByIdService<Article, int> getById = null,
     IGetSecondaryService<Article, int> getSecondary = null,
     IGetRelationshipService<Article, int> getRelationship = null,
     ICreateService<Article, int> create = null,
     IUpdateService<Article, int> update = null,
     IUpdateRelationshipService<Article, int> updateRelationships = null,
     IDeleteService<Article, int> delete = null)
     : base(options, loggerFactory, getAll, getById, getSecondary, getRelationship, create, update,
         updateRelationships, delete)
        { }
    }
}