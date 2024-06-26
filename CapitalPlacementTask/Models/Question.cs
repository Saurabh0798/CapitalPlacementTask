﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CapitalPlacementTask.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string QuestionName { get; set; }
        public int MaxChoiceAllowed { get; set; }

        [ForeignKey(nameof(ProgramId))]
        public int ProgramId { get; set; }


    }
}
