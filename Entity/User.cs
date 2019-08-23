using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Entity
{
    public partial class User
    {
        public int UserId { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [StringLength(250)]
        public string PasswordHash { get; set; }
        [Required]
        [StringLength(60)]
        public string LastName { get; set; }
        [StringLength(60)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }
        [StringLength(80)]
        public string DisplayName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public int AccessFailedCount { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
