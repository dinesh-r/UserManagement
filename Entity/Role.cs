using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Entity
{
    public partial class Role
    {
        public int RoleId { get; set; }
        [StringLength(60)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
