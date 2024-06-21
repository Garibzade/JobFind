using System.ComponentModel.DataAnnotations;

namespace JobFind.ViewModel.Category
{
    public class GetCategoryAdminVM
    {
        [Required]
        public int Id { get; set; }
        [Required,MinLength(3),MaxLength(32) ]
        public string Name { get; set; }
        [Required]

        public string Icon { get; set; }


        [Required]

        public int JobCount { get; set; }
    }
}
