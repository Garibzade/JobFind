namespace JobFind.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public string EmploymentType { get; set; }
        public DateTime PostedDate { get; set; }

        public int CategoryId { get; set; }

        public int CompanyId { get; set; }
        public Category Category { get; set; }
    }
}
