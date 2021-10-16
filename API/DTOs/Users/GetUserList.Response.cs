using System;

namespace API.DTOs.Users
{
    public class UserInfoDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }


        public int? DepartmentId { get; set; }
    }
}