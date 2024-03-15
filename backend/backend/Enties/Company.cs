using backend.Enums;

namespace backend.Enties
{
    public class Company: BaseEntity
    {
        public string Name { get; set; }
        public CompanySize size { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
