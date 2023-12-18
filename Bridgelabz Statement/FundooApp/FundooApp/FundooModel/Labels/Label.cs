using FundooModel.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using FundooModel.Notes;

namespace FundooModel.Labels
{
    public class Label
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LabelId { get; set; }
        public string LabelName { get; set; }
        [ForeignKey("Note")]
        public int? NoteId { get; set; }
        public virtual Note Note { get; set; }
        [ForeignKey("Register")]
        public int Id { get; set; }
        public virtual Register Register { get; set; }
       
    }
}
