using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="User Name")]
        public String name { get; set; }
        [Required]
        public String Uname { get; set; }
        [Required]
        [MaxLength(8,ErrorMessage="maximum length 8 to 10")]
        [DataType(DataType.Password)]
        public String password { get; set; }
    }
}