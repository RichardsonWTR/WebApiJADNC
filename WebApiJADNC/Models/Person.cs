using JsonApiDotNetCore.Models;
using System.Collections.Generic;

namespace WebApiJADNC.Models
{
    public sealed class Person : Identifiable
    {
        [Attr]
        public string Name { get; set; }

        [HasMany]
        public ICollection<Article> Articles { get; set; }
    }
}
