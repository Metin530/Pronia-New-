using almaarmudgoz.Models.Base;
namespace almaarmudgoz.Models
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }

        public List<Product>? Products { get; set; }
    }
}
