using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundooModel.Notes
{
    public class Collobrator
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollabId { get; set; }
        public int NoteId { get; set; }
        [ForeignKey("NoteId")]
        public Note Note { get; set; }
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }
    }
}
