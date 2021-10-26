using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace christmasParty.Models
{
    public class Invitation
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Email]
        [Required]
        public string Mail { get; set; }

        public bool isAttending { get; set; }
    }
}
