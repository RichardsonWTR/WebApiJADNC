
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using WebApiJADNC.Models;

namespace WebApiJADNC.Controllers
{
    public sealed class PeopleController : JsonApiController<Person>
    {
        public PeopleController(
       IJsonApiOptions options,
       ILoggerFactory loggerFactory,
       IGetAllService<Person, int> getAll = null,
       IGetByIdService<Person, int> getById = null,
       IGetSecondaryService<Person, int> getSecondary = null,
       IGetRelationshipService<Person, int> getRelationship = null,
       ICreateService<Person, int> create = null,
       IUpdateService<Person, int> update = null,
       IUpdateRelationshipService<Person, int> updateRelationships = null,
       IDeleteService<Person, int> delete = null)
       : base(options, loggerFactory, getAll, getById, getSecondary, getRelationship, create, update,
           updateRelationships, delete)
        { }
    }
}