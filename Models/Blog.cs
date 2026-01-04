using almaarmudgoz.Models.Base;
namespace almaarmudgoz.Models

{
    public class Blog : BaseEntity
    {
        public string Title { get; set; } 
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
