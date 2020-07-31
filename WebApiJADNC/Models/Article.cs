using JsonApiDotNetCore.Models;

namespace WebApiJADNC.Models
{
    public sealed class Article : Identifiable
    {
        [Attr]
        public string Title { get; set; }

        [HasOne]
        public Person Author { get; set; }
    }
}
