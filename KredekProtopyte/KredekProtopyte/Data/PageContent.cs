using System.Collections.Generic;

namespace KredekProtopyte.Data
{
    public class PageContent : Entity
    {
        public PageContent()
        {
            Elements = new List<IPageContentElement>();
        }

        public IList<IPageContentElement> Elements { get; set; }
    }
}