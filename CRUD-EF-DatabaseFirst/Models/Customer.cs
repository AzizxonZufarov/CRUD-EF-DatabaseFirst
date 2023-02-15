using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_EF_DatabaseFirst.Models
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [StringLength(500)]
        public string? PhotoUrl { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PhoneNo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? EmailId { get; set; }
    }
}
