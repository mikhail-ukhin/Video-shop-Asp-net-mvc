using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }



        public MembershipType MembershipType { get; set; }

        // Будет интерпретированно как foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}