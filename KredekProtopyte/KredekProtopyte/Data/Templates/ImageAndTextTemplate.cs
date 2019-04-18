namespace KredekProtopyte.Data.Templates
{
    public class ImageAndTextTemplate : Entity, IPageContentElement
    {
        public string ImageUrl { get; set; }

        /// <summary>
        /// True = text is on the left side.
        /// False = text is on the right side.
        /// </summary>
        public bool IsLeft { get; set; }

        public string Text { get; set; }
        public string Title { get; set; }
    }
}