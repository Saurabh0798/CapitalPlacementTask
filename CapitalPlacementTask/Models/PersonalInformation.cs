using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapitalPlacementTask.Models
{
    public class PersonalInformation
    {
        [Key]
        public int Id { get; set; }
        public string?  FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Nationality { get; set; }
        public string? CurrentResidence { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender {  get; set; }

        [ForeignKey(nameof(ProgramId))]
        public int ProgramId { get; set; }

    }
}
