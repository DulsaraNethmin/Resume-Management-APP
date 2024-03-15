using backend.Enums;

namespace backend.Dtos
{
    public class CompanyCreateDto
    {
        public string Name { get; set; }
        public CompanySize size { get; set; }
    }
}
