using System.ComponentModel.DataAnnotations;

namespace UserManagement.ViewModel.Security
{
    public class RoleModel
    {
        public int RoleId { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
    }
}
