﻿using System;

namespace WebApplication6.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? Birthdate { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}