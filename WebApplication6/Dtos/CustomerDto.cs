using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}