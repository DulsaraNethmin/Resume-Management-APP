using backend.Enums;

namespace backend.Enties
{
    public class Job : BaseEntity
    {
        public String Title { get; set; }
        public JobLevel Level { get; set; }
        public int ComponyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
