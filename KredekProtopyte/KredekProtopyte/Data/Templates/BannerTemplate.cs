namespace KredekProtopyte.Data.Templates
{
    public class BannerTemplate : Entity, IPageContentElement
    {
        public string ImageUrl { get; set; }
        public string SubTitle { get; set; }
        public string Title { get; set; }
    }
}