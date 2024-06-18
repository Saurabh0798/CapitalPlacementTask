namespace CapitalPlacementTask.Models
{
    public class RequestDto
    {
        public PersonalInformation? PersonalInformation { get; set; }
        public List<Question>? Questions { get; set; }
        public ProgramDetails? ProgramDetail { get; set; }
    }
}
