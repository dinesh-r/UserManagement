using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entity
{
    public partial class Country
    {
        public Country()
        {
            State = new HashSet<State>();
        }

        public int CountryId { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [InverseProperty("Country")]
        public virtual ICollection<State> State { get; set; }
    }
}
