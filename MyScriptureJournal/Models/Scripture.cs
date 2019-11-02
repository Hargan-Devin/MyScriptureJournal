using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Date Added"), DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        public string Notes { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Book { get; set; }
    }
}
