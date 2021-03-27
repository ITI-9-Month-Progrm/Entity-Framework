using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDB.Entity
{

    [Table("FrontEnds")]
    public class FrontEnd
    {
        [Key]
        [StringLength(50)]
       public string user_name { get; set; }

        [Required]
        [StringLength(50)]
        public string pass_word { get; set; }

    }
}
