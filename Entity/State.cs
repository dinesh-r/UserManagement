using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entity
{
    public partial class State
    {
        public int StateId { get; set; }
        public int? CountryId { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [ForeignKey("CountryId")]
        [InverseProperty("State")]
        public virtual Country Country { get; set; }
    }
}
