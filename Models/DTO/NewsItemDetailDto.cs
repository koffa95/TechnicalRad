namespace Models.DTO
{
    public class NewsItemDetailDto
    {
        public int Id { get; set;}
        public string Title { get; set;}
        public string ImgSource { get; set;}
        public string ShortDescription { get; set;}
        public string LongDescription { get; set;}
        public System.DateTime PublishDate { get; set;}
    }
}