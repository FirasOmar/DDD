using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Users
{
    public class AddUserRequest
    {
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }



        [StringLength(255)]
        public string Address { get; set; }


        [Required]
        public int? DepartmentId { get; set; }
    }
}