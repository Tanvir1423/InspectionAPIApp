using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(20)]

        public string CategoryName { get; set; } = string.Empty;
        [StringLength(200)]
        public string CategoryTypes { get; set; } = string.Empty;
    }
}
