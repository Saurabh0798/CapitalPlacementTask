using System.ComponentModel.DataAnnotations;

namespace CapitalPlacementTask.Models
{
    public class ProgramDetails
    {
        [Key]
        public int ProgramId { get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }

    }
}
