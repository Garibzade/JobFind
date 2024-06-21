namespace JobFind.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int JobCount { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}
