using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApplicationDAL.Entities
{
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
