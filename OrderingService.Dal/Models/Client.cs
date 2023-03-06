﻿using System.ComponentModel.DataAnnotations;

namespace OrderingService.Dal.Models
{
    public class Client
    {
        public Guid Id { get; set; }

        public string FullName { get; set; } = null!;

        public string Phone { get; set; } = null!;
    }
}
