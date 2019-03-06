using System.Collections.Generic;

namespace KredekProtopyte.Data
{
    public class PageContent : Entity
    {
        public PageContent()
        {
            Elements = new List<IPageContentElement>();
        }

        public List<IPageContentElement> Elements { get; set; }
    }
}