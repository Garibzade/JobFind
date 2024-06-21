using System.ComponentModel.DataAnnotations;

namespace JobFind.ViewModel.Category
{
    public class EditCategoryVM
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public IFormFile? IconFile { get; set; }
    }
}
