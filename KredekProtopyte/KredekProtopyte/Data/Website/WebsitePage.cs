using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace KredekProtopyte.Data.Website
{
    public class WebsitePage
    {
        public PageContent Content { get; set; }

        /// <summary>
        /// True - page is in an archive and it is not active (doesn't rendering on site)
        /// </summary>
        public bool IsArchived { get; set; }

        /// <summary>
        /// Page Id in a database
        /// </summary>
        [Key]
        public string Name { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        public string Title { get; set; }
    }
}