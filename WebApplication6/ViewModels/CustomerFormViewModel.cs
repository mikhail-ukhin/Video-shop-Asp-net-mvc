using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Membership Type")]
        [Required(ErrorMessage = "Please choose membership type")]
        public byte? MembershipTypeId { get; set; }

        public CustomerFormViewModel()
        {
            Id = 0;
        }

        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Birthdate = customer.Birthdate;
            MembershipTypeId = customer.MembershipTypeId;
            IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
        }

    }
}