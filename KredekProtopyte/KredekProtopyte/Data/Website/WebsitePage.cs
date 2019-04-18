using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace KredekProtopyte.Data.Website
{
    public class WebsitePage
    {
        public PageContent Content { get; set; }

        [Key]
        public string Name { get; set; }

        public string Text { get; set; }
        public string Title { get; set; }
    }
}